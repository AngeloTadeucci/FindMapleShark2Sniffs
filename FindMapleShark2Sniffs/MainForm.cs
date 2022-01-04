using System.Diagnostics;
using System.ComponentModel;
using FindMapleShark2Sniffs.Tools;

namespace FindMapleShark2Sniffs;

public partial class MainForm : Form
{
    private string[] Files;
    private List<string> matchedFiles = new List<string>();

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

        textBox1.Text = dialog.SelectedPath;

        Files = Directory.GetFiles(dialog.SelectedPath, "*.msb", SearchOption.AllDirectories);

        label1.Text = $"Found {Files.Length} .msb files";
        label1.Visible = true;
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
        label2.Text = "Searching...";

        progressBar1.Maximum = Files.Length;
        progressBar1.Step = 1;
        progressBar1.Value = 0;

        backgroundWorker1.WorkerReportsProgress = true;
        backgroundWorker1.RunWorkerAsync();
    }

    private void ResultListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var mouseEventArgs = e as MouseEventArgs;
        int index = resultListBox.IndexFromPoint(mouseEventArgs.Location);
        if (index != ListBox.NoMatches)
        {
            new Process
            {
                StartInfo = new ProcessStartInfo(@resultListBox.Items[index].ToString())
                {
                    UseShellExecute = true
                }
            }.Start();
        }
    }

    private void InRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        OutRadioButton.Checked = !InRadioButton.Checked;
    }

    private void OutRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        InRadioButton.Checked = !OutRadioButton.Checked;
    }

    private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
        progressBar1.Value = e.ProgressPercentage;
    }

    private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        matchedFiles = new();

        var backgroundWorker = sender as BackgroundWorker;

        int i = 0;
        foreach (string? filePath in Files)
        {
            backgroundWorker.ReportProgress(i++);
            bool opCodeMatched = false;
            bool gmsMatched = false;
            (MsbMetadata metadata, IEnumerable<MaplePacket> packets) = FileLoader.ReadMsbFile(filePath);
            if (metadata is null)
            {
                return;
            }

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
                    matchedFiles.Add(filePath);
                }
                else
                {
                    matchedFiles.Add(filePath);
                }
            }
            else if (!opCodeCheckBox.Checked && gmsCheckBox.Checked && gmsMatched)
            {
                matchedFiles.Add(filePath);
            }
        }
    }

    private void backgroundWorker_Finish(object sender, RunWorkerCompletedEventArgs e)
    {
        label2.Text = $"Found {matchedFiles.Count} files.";
        label2.Visible = true;

        resultListBox.Items.Clear();
        foreach (var item in matchedFiles)
        {
            resultListBox.Items.Add(item);
        }
    }
}
