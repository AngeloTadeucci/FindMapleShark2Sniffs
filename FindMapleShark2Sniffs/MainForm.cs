using System.ComponentModel;
using System.Diagnostics;
using FindMapleShark2Sniffs.MapleShark2_Files;
using Maple2.PacketLib.Tools;

namespace FindMapleShark2Sniffs;

public partial class MainForm : Form
{
    private string[]? Files;
    private List<string> MatchedFiles = new();

    public MainForm()
    {
        InitializeComponent();
        modeToolTip.SetToolTip(modeCheckBox, "Read the first byte of the packet and compares with the set value.");
    }

    private void FindFolderClick(object sender, EventArgs e)
    {
        FolderBrowserDialog dialog = new();
        if (dialog.ShowDialog() == DialogResult.Cancel)
        {
            return;
        }

        if (string.IsNullOrEmpty(dialog.SelectedPath))
        {
            return;
        }

        Files = Directory.GetFiles(dialog.SelectedPath, "*.msb", SearchOption.AllDirectories);

        statusLabel.Text = $"Found {Files.Length} .msb files";
        statusLabel.Visible = true;
    }

    private void FindFilesClick(object sender, EventArgs e)
    {
        if (Files is null)
        {
            MessageBox.Show("Select a folder!", "Error");
            return;
        }

        if (opCodeCheckBox.Checked && opcodeInput.Value == 0)
        {
            MessageBox.Show("OpCode was zero. No packets will be found.", "Error");
            return;
        }

        if (searchIdCheckBox.Checked && searchId.Value == 0)
        {
            MessageBox.Show("Search id was zero. No packets will be found.", "Error");
            return;
        }

        if (!opCodeCheckBox.Checked && !searchIdCheckBox.Checked)
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
        progressBar.Visible = true;

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
            (MsbMetadata metadata, IEnumerable<MaplePacket> packets) = FileLoader.ReadMsbFile(filePath);
            IEnumerable<MaplePacket> packetsList = packets.ToList();

            if (searchIdCheckBox.Checked)
            {
                // this is ugly but im dumb and idk an easier way to do it :)), thank god only me uses this app and this doesn't matter
                PacketWriter pw = new();
                pw.WriteInt((int) searchId.Value);

                byte[] idBytes = pw.Buffer.Take(4).ToArray();

                if (FilterHelpers.SearchBytes(packetsList, idBytes))
                {
                    MatchedFiles.Add(filePath);
                }

                continue;
            }

            if (!opCodeCheckBox.Checked)
            {
                continue;
            }

            if (!FilterHelpers.FilterOpCode(packetsList, opcodeInput.Value, OutRadioButton.Checked))
            {
                continue;
            }

            if (modeCheckBox.Checked && lengthCheckBox.Checked &&
                !FilterHelpers.FilterMode(packetsList, opcodeInput.Value, modeInput.Value, OutRadioButton.Checked, lengthInput.Value))
            {
                continue;
            }

            if (modeCheckBox.Checked && !lengthCheckBox.Checked &&
                !FilterHelpers.FilterMode(packetsList, opcodeInput.Value, modeInput.Value, OutRadioButton.Checked))
            {
                continue;
            }

            if (!modeCheckBox.Checked && lengthCheckBox.Checked &&
                !FilterHelpers.FilterLength(packetsList, opcodeInput.Value, lengthInput.Value))
            {
                continue;
            }

            if (gmsCheckBox.Checked && metadata.Build != 12)
            {
                continue;
            }

            MatchedFiles.Add(filePath);
        }
    }

    private void backgroundWorker_Finish(object sender, RunWorkerCompletedEventArgs e)
    {
        statusLabel.Text = $"Found {MatchedFiles.Count} files.";
        statusLabel.Visible = true;
        progressBar.Visible = false;

        resultListBox.Items.Clear();
        foreach (string item in MatchedFiles)
        {
            resultListBox.Items.Add(item);
        }
    }

    private void onItemIdValueChange(object sender, EventArgs e)
    {
        MapleShark2_Files.PacketWriter pw = new();
        pw.WriteInt((int) searchId.Value);

        byte[] idBytes = pw.Buffer.Take(4).ToArray();

        hexIdTextBox.Text = idBytes.ToHexString(' ');
    }

    private void searchIdCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (opCodeCheckBox.Checked && searchIdCheckBox.Checked)
        {
            opCodeCheckBox.Checked = false;
            packetGroupBox.Enabled = false;
        }
    }

    private void opCodeCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (searchIdCheckBox.Checked && opCodeCheckBox.Checked)
        {
            searchIdCheckBox.Checked = false;
        }

        packetGroupBox.Enabled = opCodeCheckBox.Checked;
    }
}
