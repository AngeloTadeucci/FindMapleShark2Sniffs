using System.ComponentModel;
using System.Diagnostics;
using FindMapleShark2Sniffs.MapleShark2_Files;

namespace FindMapleShark2Sniffs;

public partial class MainForm : Form
{
    private string[]? Files;
    private List<string> MatchedFiles = new();

    public MainForm()
    {
        InitializeComponent();
    }

    private void FindFolderClick(object sender, EventArgs e)
    {
        FolderBrowserDialog dialog = new();
        dialog.ShowDialog();

        if (string.IsNullOrEmpty(dialog.SelectedPath))
        {
            return;
        }

        selectedPathTextBox.Text = dialog.SelectedPath;

        Files = Directory.GetFiles(dialog.SelectedPath, "*.msb", SearchOption.AllDirectories);

        filesFoundLabel.Text = $"Found {Files.Length} .msb files";
        filesFoundLabel.Visible = true;
    }

    private void FindFilesClick(object sender, EventArgs e)
    {
        if (Files is null)
        {
            MessageBox.Show("Select a folder!", "Error");
            return;
        }

        if (!opCodeCheckBox.Checked && !gmsCheckBox.Checked)
        {
            MessageBox.Show("Select at least one filter!", "Error");
            return;
        }

        if (SearchBackgroundWorker.IsBusy)
        {
            MessageBox.Show("Still searching...", "Error");
            return;
        }

        statusLabel.Text = "Searching...";

        progressBar.Maximum = Files.Length;
        progressBar.Step = 1;
        progressBar.Value = 0;

        SearchBackgroundWorker.WorkerReportsProgress = true;
        SearchBackgroundWorker.RunWorkerAsync();
    }

    private void ResultListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (e is not MouseEventArgs mouseEventArgs)
        {
            return;
        }

        int index = resultListBox.IndexFromPoint(mouseEventArgs.Location);
        if (index == ListBox.NoMatches)
        {
            return;
        }

        new Process
        {
            StartInfo = new(resultListBox.Items[index].ToString()!)
            {
                UseShellExecute = true
            }
        }.Start();
    }

    private void InRadioButton_CheckedChanged(object sender, EventArgs e) => OutRadioButton.Checked = !InRadioButton.Checked;

    private void OutRadioButton_CheckedChanged(object sender, EventArgs e) => InRadioButton.Checked = !OutRadioButton.Checked;

    private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) => progressBar.Value = e.ProgressPercentage;

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
        if (Files is null)
        {
            return;
        }

        MatchedFiles = new();

        BackgroundWorker? backgroundWorker = sender as BackgroundWorker;

        int i = 0;
        foreach (string filePath in Files)
        {
            backgroundWorker!.ReportProgress(i++);
            bool opCodeMatched = false;
            bool gmsMatched = false;
            (MsbMetadata metadata, IEnumerable<MaplePacket> packets) = FileLoader.ReadMsbFile(filePath);

            if (opCodeCheckBox.Checked)
            {
                if (packets.Any(x => x.Opcode == opcodeInput.Value && x.Outbound == OutRadioButton.Checked))
                {
                    opCodeMatched = true;
                }
            }

            if (gmsCheckBox.Checked && metadata.Build == 12)
            {
                gmsMatched = true;
            }

            if (opCodeCheckBox.Checked && opCodeMatched)
            {
                if (gmsCheckBox.Checked && gmsMatched)
                {
                    MatchedFiles.Add(filePath);
                }
                else
                {
                    MatchedFiles.Add(filePath);
                }
            }
            else if (!opCodeCheckBox.Checked && gmsCheckBox.Checked && gmsMatched)
            {
                MatchedFiles.Add(filePath);
            }
        }
    }

    private void backgroundWorker_Finish(object sender, RunWorkerCompletedEventArgs e)
    {
        statusLabel.Text = $"Found {MatchedFiles.Count} files.";
        statusLabel.Visible = true;

        resultListBox.Items.Clear();
        foreach (string item in MatchedFiles)
        {
            resultListBox.Items.Add(item);
        }
    }
}
