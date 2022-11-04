namespace FindMapleShark2Sniffs
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.packetGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lengthInput = new System.Windows.Forms.NumericUpDown();
            this.lengthCheckBox = new System.Windows.Forms.CheckBox();
            this.modeInput = new System.Windows.Forms.NumericUpDown();
            this.modeCheckBox = new System.Windows.Forms.CheckBox();
            this.gmsCheckBox = new System.Windows.Forms.CheckBox();
            this.InRadioButton = new System.Windows.Forms.RadioButton();
            this.OutRadioButton = new System.Windows.Forms.RadioButton();
            this.opcodeInput = new System.Windows.Forms.NumericUpDown();
            this.opCodeCheckBox = new System.Windows.Forms.CheckBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SearchBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.modeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchIdCheckBox = new System.Windows.Forms.CheckBox();
            this.searchId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.hexIdTextBox = new System.Windows.Forms.TextBox();
            this.filtersGroupBox.SuspendLayout();
            this.packetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcodeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchId)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FindFolderClick);
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Controls.Add(this.packetGroupBox);
            this.filtersGroupBox.Controls.Add(this.opcodeInput);
            this.filtersGroupBox.Controls.Add(this.opCodeCheckBox);
            this.filtersGroupBox.Location = new System.Drawing.Point(12, 41);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Size = new System.Drawing.Size(243, 163);
            this.filtersGroupBox.TabIndex = 3;
            this.filtersGroupBox.TabStop = false;
            this.filtersGroupBox.Text = "Filters";
            // 
            // packetGroupBox
            // 
            this.packetGroupBox.Controls.Add(this.label4);
            this.packetGroupBox.Controls.Add(this.lengthInput);
            this.packetGroupBox.Controls.Add(this.lengthCheckBox);
            this.packetGroupBox.Controls.Add(this.modeInput);
            this.packetGroupBox.Controls.Add(this.modeCheckBox);
            this.packetGroupBox.Controls.Add(this.gmsCheckBox);
            this.packetGroupBox.Controls.Add(this.InRadioButton);
            this.packetGroupBox.Controls.Add(this.OutRadioButton);
            this.packetGroupBox.Enabled = false;
            this.packetGroupBox.Location = new System.Drawing.Point(6, 50);
            this.packetGroupBox.Name = "packetGroupBox";
            this.packetGroupBox.Size = new System.Drawing.Size(231, 107);
            this.packetGroupBox.TabIndex = 9;
            this.packetGroupBox.TabStop = false;
            this.packetGroupBox.Text = "Packet values";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(103, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // lengthInput
            // 
            this.lengthInput.Location = new System.Drawing.Point(105, 76);
            this.lengthInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(120, 23);
            this.lengthInput.TabIndex = 12;
            // 
            // lengthCheckBox
            // 
            this.lengthCheckBox.AutoSize = true;
            this.lengthCheckBox.Location = new System.Drawing.Point(6, 80);
            this.lengthCheckBox.Name = "lengthCheckBox";
            this.lengthCheckBox.Size = new System.Drawing.Size(82, 19);
            this.lengthCheckBox.TabIndex = 11;
            this.lengthCheckBox.Text = "Length >=";
            this.lengthCheckBox.UseVisualStyleBackColor = true;
            // 
            // modeInput
            // 
            this.modeInput.Location = new System.Drawing.Point(105, 47);
            this.modeInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.modeInput.Name = "modeInput";
            this.modeInput.Size = new System.Drawing.Size(120, 23);
            this.modeInput.TabIndex = 10;
            // 
            // modeCheckBox
            // 
            this.modeCheckBox.AutoSize = true;
            this.modeCheckBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.modeCheckBox.Location = new System.Drawing.Point(6, 51);
            this.modeCheckBox.Name = "modeCheckBox";
            this.modeCheckBox.Size = new System.Drawing.Size(57, 19);
            this.modeCheckBox.TabIndex = 9;
            this.modeCheckBox.Text = "Mode";
            this.modeCheckBox.UseVisualStyleBackColor = true;
            // 
            // gmsCheckBox
            // 
            this.gmsCheckBox.AutoSize = true;
            this.gmsCheckBox.Location = new System.Drawing.Point(118, 22);
            this.gmsCheckBox.Name = "gmsCheckBox";
            this.gmsCheckBox.Size = new System.Drawing.Size(80, 19);
            this.gmsCheckBox.TabIndex = 3;
            this.gmsCheckBox.Text = "GMS (v12)";
            this.gmsCheckBox.UseVisualStyleBackColor = true;
            // 
            // InRadioButton
            // 
            this.InRadioButton.AutoSize = true;
            this.InRadioButton.Checked = true;
            this.InRadioButton.Location = new System.Drawing.Point(6, 22);
            this.InRadioButton.Name = "InRadioButton";
            this.InRadioButton.Size = new System.Drawing.Size(37, 19);
            this.InRadioButton.TabIndex = 7;
            this.InRadioButton.TabStop = true;
            this.InRadioButton.Text = "IN";
            this.InRadioButton.UseVisualStyleBackColor = true;
            this.InRadioButton.CheckedChanged += new System.EventHandler(this.InRadioButton_CheckedChanged);
            // 
            // OutRadioButton
            // 
            this.OutRadioButton.AutoSize = true;
            this.OutRadioButton.Location = new System.Drawing.Point(49, 22);
            this.OutRadioButton.Name = "OutRadioButton";
            this.OutRadioButton.Size = new System.Drawing.Size(48, 19);
            this.OutRadioButton.TabIndex = 8;
            this.OutRadioButton.Text = "OUT";
            this.OutRadioButton.UseVisualStyleBackColor = true;
            this.OutRadioButton.CheckedChanged += new System.EventHandler(this.OutRadioButton_CheckedChanged);
            // 
            // opcodeInput
            // 
            this.opcodeInput.Location = new System.Drawing.Point(90, 21);
            this.opcodeInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.opcodeInput.Name = "opcodeInput";
            this.opcodeInput.Size = new System.Drawing.Size(120, 23);
            this.opcodeInput.TabIndex = 4;
            // 
            // opCodeCheckBox
            // 
            this.opCodeCheckBox.AutoSize = true;
            this.opCodeCheckBox.Location = new System.Drawing.Point(6, 22);
            this.opCodeCheckBox.Name = "opCodeCheckBox";
            this.opCodeCheckBox.Size = new System.Drawing.Size(70, 19);
            this.opCodeCheckBox.TabIndex = 0;
            this.opCodeCheckBox.Text = "OpCode";
            this.opCodeCheckBox.UseVisualStyleBackColor = true;
            this.opCodeCheckBox.CheckedChanged += new System.EventHandler(this.opCodeCheckBox_CheckedChanged);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 15;
            this.resultListBox.Location = new System.Drawing.Point(261, 12);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(501, 379);
            this.resultListBox.TabIndex = 4;
            this.resultListBox.DoubleClick += new System.EventHandler(this.ResultListBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Find files";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.FindFilesClick);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(103, 16);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(38, 15);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "label2";
            this.statusLabel.Visible = false;
            // 
            // SearchBackgroundWorker
            // 
            this.SearchBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.SearchBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.SearchBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Finish);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(155, 362);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 7;
            this.progressBar.Visible = false;
            // 
            // searchIdCheckBox
            // 
            this.searchIdCheckBox.AutoSize = true;
            this.searchIdCheckBox.Location = new System.Drawing.Point(12, 210);
            this.searchIdCheckBox.Name = "searchIdCheckBox";
            this.searchIdCheckBox.Size = new System.Drawing.Size(74, 19);
            this.searchIdCheckBox.TabIndex = 10;
            this.searchIdCheckBox.Text = "Search id";
            this.searchIdCheckBox.UseVisualStyleBackColor = true;
            this.searchIdCheckBox.CheckedChanged += new System.EventHandler(this.searchIdCheckBox_CheckedChanged);
            // 
            // searchId
            // 
            this.searchId.Location = new System.Drawing.Point(92, 209);
            this.searchId.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(120, 23);
            this.searchId.TabIndex = 10;
            this.searchId.ValueChanged += new System.EventHandler(this.onItemIdValueChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID in HEX:";
            // 
            // hexIdTextBox
            // 
            this.hexIdTextBox.Location = new System.Drawing.Point(92, 238);
            this.hexIdTextBox.Name = "hexIdTextBox";
            this.hexIdTextBox.ReadOnly = true;
            this.hexIdTextBox.Size = new System.Drawing.Size(120, 23);
            this.hexIdTextBox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(774, 397);
            this.Controls.Add(this.hexIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchId);
            this.Controls.Add(this.searchIdCheckBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.filtersGroupBox);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Find MapleShark2 Sniffs";
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            this.packetGroupBox.ResumeLayout(false);
            this.packetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcodeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private GroupBox filtersGroupBox;
        private CheckBox gmsCheckBox;
        private CheckBox opCodeCheckBox;
        private ListBox resultListBox;
        private Button button2;
        private NumericUpDown opcodeInput;
        private Label statusLabel;
        private RadioButton InRadioButton;
        private RadioButton OutRadioButton;
        private System.ComponentModel.BackgroundWorker SearchBackgroundWorker;
        private ProgressBar progressBar;
        private GroupBox packetGroupBox;
        private NumericUpDown lengthInput;
        private CheckBox lengthCheckBox;
        private NumericUpDown modeInput;
        private CheckBox modeCheckBox;
        private ToolTip modeToolTip;
        private Label label4;
        private CheckBox searchIdCheckBox;
        private NumericUpDown searchId;
        private Label label1;
        private TextBox hexIdTextBox;
    }
}
