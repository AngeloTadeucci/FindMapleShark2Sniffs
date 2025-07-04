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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            button1 = new System.Windows.Forms.Button();
            filtersGroupBox = new System.Windows.Forms.GroupBox();
            packetGroupBox = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            lengthInput = new System.Windows.Forms.NumericUpDown();
            lengthCheckBox = new System.Windows.Forms.CheckBox();
            modeInput = new System.Windows.Forms.NumericUpDown();
            modeCheckBox = new System.Windows.Forms.CheckBox();
            gmsCheckBox = new System.Windows.Forms.CheckBox();
            InRadioButton = new System.Windows.Forms.RadioButton();
            OutRadioButton = new System.Windows.Forms.RadioButton();
            opcodeInput = new System.Windows.Forms.NumericUpDown();
            opCodeCheckBox = new System.Windows.Forms.CheckBox();
            resultListBox = new System.Windows.Forms.ListBox();
            button2 = new System.Windows.Forms.Button();
            statusLabel = new System.Windows.Forms.Label();
            SearchBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            progressBar = new System.Windows.Forms.ProgressBar();
            modeToolTip = new System.Windows.Forms.ToolTip(components);
            searchIdCheckBox = new System.Windows.Forms.CheckBox();
            searchId = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            hexIdTextBox = new System.Windows.Forms.TextBox();
            searchTextCheckbox = new System.Windows.Forms.CheckBox();
            searchTextInput = new System.Windows.Forms.TextBox();
            filtersGroupBox.SuspendLayout();
            packetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) lengthInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize) modeInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize) opcodeInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize) searchId).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(85, 23);
            button1.TabIndex = 0;
            button1.Text = "Open folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += FindFolderClick;
            // 
            // filtersGroupBox
            // 
            filtersGroupBox.Controls.Add(packetGroupBox);
            filtersGroupBox.Controls.Add(opcodeInput);
            filtersGroupBox.Controls.Add(opCodeCheckBox);
            filtersGroupBox.Location = new System.Drawing.Point(12, 41);
            filtersGroupBox.Name = "filtersGroupBox";
            filtersGroupBox.Size = new System.Drawing.Size(243, 163);
            filtersGroupBox.TabIndex = 3;
            filtersGroupBox.TabStop = false;
            filtersGroupBox.Text = "Filters";
            // 
            // packetGroupBox
            // 
            packetGroupBox.Controls.Add(label4);
            packetGroupBox.Controls.Add(lengthInput);
            packetGroupBox.Controls.Add(lengthCheckBox);
            packetGroupBox.Controls.Add(modeInput);
            packetGroupBox.Controls.Add(modeCheckBox);
            packetGroupBox.Controls.Add(gmsCheckBox);
            packetGroupBox.Controls.Add(InRadioButton);
            packetGroupBox.Controls.Add(OutRadioButton);
            packetGroupBox.Enabled = false;
            packetGroupBox.Location = new System.Drawing.Point(6, 50);
            packetGroupBox.Name = "packetGroupBox";
            packetGroupBox.Size = new System.Drawing.Size(231, 107);
            packetGroupBox.TabIndex = 9;
            packetGroupBox.TabStop = false;
            packetGroupBox.Text = "Packet values";
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            label4.Location = new System.Drawing.Point(103, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(1, 20);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // lengthInput
            // 
            lengthInput.Location = new System.Drawing.Point(105, 76);
            lengthInput.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            lengthInput.Name = "lengthInput";
            lengthInput.Size = new System.Drawing.Size(120, 23);
            lengthInput.TabIndex = 12;
            // 
            // lengthCheckBox
            // 
            lengthCheckBox.AutoSize = true;
            lengthCheckBox.Location = new System.Drawing.Point(6, 80);
            lengthCheckBox.Name = "lengthCheckBox";
            lengthCheckBox.Size = new System.Drawing.Size(82, 19);
            lengthCheckBox.TabIndex = 11;
            lengthCheckBox.Text = "Length >=";
            lengthCheckBox.UseVisualStyleBackColor = true;
            // 
            // modeInput
            // 
            modeInput.Location = new System.Drawing.Point(105, 47);
            modeInput.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            modeInput.Name = "modeInput";
            modeInput.Size = new System.Drawing.Size(120, 23);
            modeInput.TabIndex = 10;
            // 
            // modeCheckBox
            // 
            modeCheckBox.AutoSize = true;
            modeCheckBox.Cursor = System.Windows.Forms.Cursors.Help;
            modeCheckBox.Location = new System.Drawing.Point(6, 51);
            modeCheckBox.Name = "modeCheckBox";
            modeCheckBox.Size = new System.Drawing.Size(57, 19);
            modeCheckBox.TabIndex = 9;
            modeCheckBox.Text = "Mode";
            modeCheckBox.UseVisualStyleBackColor = true;
            // 
            // gmsCheckBox
            // 
            gmsCheckBox.AutoSize = true;
            gmsCheckBox.Location = new System.Drawing.Point(118, 22);
            gmsCheckBox.Name = "gmsCheckBox";
            gmsCheckBox.Size = new System.Drawing.Size(80, 19);
            gmsCheckBox.TabIndex = 3;
            gmsCheckBox.Text = "GMS (v12)";
            gmsCheckBox.UseVisualStyleBackColor = true;
            // 
            // InRadioButton
            // 
            InRadioButton.AutoSize = true;
            InRadioButton.Checked = true;
            InRadioButton.Location = new System.Drawing.Point(6, 22);
            InRadioButton.Name = "InRadioButton";
            InRadioButton.Size = new System.Drawing.Size(37, 19);
            InRadioButton.TabIndex = 7;
            InRadioButton.TabStop = true;
            InRadioButton.Text = "IN";
            InRadioButton.UseVisualStyleBackColor = true;
            InRadioButton.CheckedChanged += InRadioButton_CheckedChanged;
            // 
            // OutRadioButton
            // 
            OutRadioButton.AutoSize = true;
            OutRadioButton.Location = new System.Drawing.Point(49, 22);
            OutRadioButton.Name = "OutRadioButton";
            OutRadioButton.Size = new System.Drawing.Size(49, 19);
            OutRadioButton.TabIndex = 8;
            OutRadioButton.Text = "OUT";
            OutRadioButton.UseVisualStyleBackColor = true;
            OutRadioButton.CheckedChanged += OutRadioButton_CheckedChanged;
            // 
            // opcodeInput
            // 
            opcodeInput.Location = new System.Drawing.Point(90, 21);
            opcodeInput.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            opcodeInput.Name = "opcodeInput";
            opcodeInput.Size = new System.Drawing.Size(120, 23);
            opcodeInput.TabIndex = 4;
            // 
            // opCodeCheckBox
            // 
            opCodeCheckBox.AutoSize = true;
            opCodeCheckBox.Location = new System.Drawing.Point(6, 22);
            opCodeCheckBox.Name = "opCodeCheckBox";
            opCodeCheckBox.Size = new System.Drawing.Size(70, 19);
            opCodeCheckBox.TabIndex = 0;
            opCodeCheckBox.Text = "OpCode";
            opCodeCheckBox.UseVisualStyleBackColor = true;
            opCodeCheckBox.CheckedChanged += opCodeCheckBox_CheckedChanged;
            // 
            // resultListBox
            // 
            resultListBox.FormattingEnabled = true;
            resultListBox.ItemHeight = 15;
            resultListBox.Location = new System.Drawing.Point(261, 12);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new System.Drawing.Size(501, 379);
            resultListBox.TabIndex = 4;
            resultListBox.DoubleClick += ResultListBox_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(12, 362);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Find files";
            button2.UseVisualStyleBackColor = true;
            button2.Click += FindFilesClick;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(103, 16);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(38, 15);
            statusLabel.TabIndex = 6;
            statusLabel.Text = "label2";
            statusLabel.Visible = false;
            // 
            // SearchBackgroundWorker
            // 
            SearchBackgroundWorker.DoWork += backgroundWorker1_DoWork;
            SearchBackgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            SearchBackgroundWorker.RunWorkerCompleted += backgroundWorker_Finish;
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(155, 362);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(100, 23);
            progressBar.TabIndex = 7;
            progressBar.Visible = false;
            // 
            // searchIdCheckBox
            // 
            searchIdCheckBox.AutoSize = true;
            searchIdCheckBox.Location = new System.Drawing.Point(12, 210);
            searchIdCheckBox.Name = "searchIdCheckBox";
            searchIdCheckBox.Size = new System.Drawing.Size(74, 19);
            searchIdCheckBox.TabIndex = 10;
            searchIdCheckBox.Text = "Search id";
            searchIdCheckBox.UseVisualStyleBackColor = true;
            searchIdCheckBox.CheckedChanged += searchIdCheckBox_CheckedChanged;
            // 
            // searchId
            // 
            searchId.Location = new System.Drawing.Point(92, 209);
            searchId.Maximum = new decimal(new int[] {2147483647, 0, 0, 0});
            searchId.Name = "searchId";
            searchId.Size = new System.Drawing.Size(151, 23);
            searchId.TabIndex = 10;
            searchId.ValueChanged += onItemIdValueChange;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 241);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 15);
            label1.TabIndex = 11;
            label1.Text = "ID in HEX:";
            // 
            // hexIdTextBox
            // 
            hexIdTextBox.Location = new System.Drawing.Point(92, 238);
            hexIdTextBox.Name = "hexIdTextBox";
            hexIdTextBox.ReadOnly = true;
            hexIdTextBox.Size = new System.Drawing.Size(151, 23);
            hexIdTextBox.TabIndex = 12;
            // 
            // searchTextCheckbox
            // 
            searchTextCheckbox.Location = new System.Drawing.Point(12, 267);
            searchTextCheckbox.Name = "searchTextCheckbox";
            searchTextCheckbox.Size = new System.Drawing.Size(104, 24);
            searchTextCheckbox.TabIndex = 13;
            searchTextCheckbox.Text = "Search text";
            searchTextCheckbox.UseVisualStyleBackColor = true;
            // 
            // searchTextInput
            // 
            searchTextInput.Location = new System.Drawing.Point(92, 268);
            searchTextInput.Name = "searchTextInput";
            searchTextInput.Size = new System.Drawing.Size(151, 23);
            searchTextInput.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(774, 397);
            Controls.Add(searchTextInput);
            Controls.Add(searchTextCheckbox);
            Controls.Add(hexIdTextBox);
            Controls.Add(label1);
            Controls.Add(searchId);
            Controls.Add(searchIdCheckBox);
            Controls.Add(progressBar);
            Controls.Add(statusLabel);
            Controls.Add(button2);
            Controls.Add(resultListBox);
            Controls.Add(filtersGroupBox);
            Controls.Add(button1);
            MaximizeBox = false;
            ShowIcon = false;
            Text = "Find MapleShark2 Sniffs";
            filtersGroupBox.ResumeLayout(false);
            filtersGroupBox.PerformLayout();
            packetGroupBox.ResumeLayout(false);
            packetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) lengthInput).EndInit();
            ((System.ComponentModel.ISupportInitialize) modeInput).EndInit();
            ((System.ComponentModel.ISupportInitialize) opcodeInput).EndInit();
            ((System.ComponentModel.ISupportInitialize) searchId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox searchTextInput;

        private System.Windows.Forms.CheckBox searchTextCheckbox;

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
        private System.Windows.Forms.NumericUpDown searchId;
        private Label label1;
        private System.Windows.Forms.TextBox hexIdTextBox;
    }
}
