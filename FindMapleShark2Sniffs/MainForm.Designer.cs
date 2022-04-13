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
            this.selectedPathTextBox = new System.Windows.Forms.TextBox();
            this.filesFoundLabel = new System.Windows.Forms.Label();
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.OutRadioButton = new System.Windows.Forms.RadioButton();
            this.InRadioButton = new System.Windows.Forms.RadioButton();
            this.opcodeInput = new System.Windows.Forms.NumericUpDown();
            this.gmsCheckBox = new System.Windows.Forms.CheckBox();
            this.opCodeCheckBox = new System.Windows.Forms.CheckBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusLabel = new System.Windows.Forms.Label();
            this.SearchBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.filtersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opcodeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FindFolderClick);
            // 
            // textBox1
            // 
            this.selectedPathTextBox.Location = new System.Drawing.Point(93, 12);
            this.selectedPathTextBox.Name = "selectedPathTextBox";
            this.selectedPathTextBox.ReadOnly = true;
            this.selectedPathTextBox.Size = new System.Drawing.Size(346, 23);
            this.selectedPathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.filesFoundLabel.AutoSize = true;
            this.filesFoundLabel.Location = new System.Drawing.Point(445, 16);
            this.filesFoundLabel.Name = "filesFoundLabel";
            this.filesFoundLabel.Size = new System.Drawing.Size(103, 15);
            this.filesFoundLabel.TabIndex = 2;
            this.filesFoundLabel.Text = "Found x .msb files";
            this.filesFoundLabel.Visible = false;
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Controls.Add(this.OutRadioButton);
            this.filtersGroupBox.Controls.Add(this.InRadioButton);
            this.filtersGroupBox.Controls.Add(this.opcodeInput);
            this.filtersGroupBox.Controls.Add(this.gmsCheckBox);
            this.filtersGroupBox.Controls.Add(this.opCodeCheckBox);
            this.filtersGroupBox.Location = new System.Drawing.Point(12, 41);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Size = new System.Drawing.Size(536, 76);
            this.filtersGroupBox.TabIndex = 3;
            this.filtersGroupBox.TabStop = false;
            this.filtersGroupBox.Text = "Filters";
            // 
            // OutRadioButton
            // 
            this.OutRadioButton.AutoSize = true;
            this.OutRadioButton.Location = new System.Drawing.Point(49, 47);
            this.OutRadioButton.Name = "OutRadioButton";
            this.OutRadioButton.Size = new System.Drawing.Size(48, 19);
            this.OutRadioButton.TabIndex = 8;
            this.OutRadioButton.Text = "OUT";
            this.OutRadioButton.UseVisualStyleBackColor = true;
            this.OutRadioButton.CheckedChanged += new System.EventHandler(this.OutRadioButton_CheckedChanged);
            // 
            // InRadioButton
            // 
            this.InRadioButton.AutoSize = true;
            this.InRadioButton.Checked = true;
            this.InRadioButton.Location = new System.Drawing.Point(6, 47);
            this.InRadioButton.Name = "InRadioButton";
            this.InRadioButton.Size = new System.Drawing.Size(37, 19);
            this.InRadioButton.TabIndex = 7;
            this.InRadioButton.TabStop = true;
            this.InRadioButton.Text = "IN";
            this.InRadioButton.UseVisualStyleBackColor = true;
            this.InRadioButton.CheckedChanged += new System.EventHandler(this.InRadioButton_CheckedChanged);
            // 
            // opcodeInput
            // 
            this.opcodeInput.Location = new System.Drawing.Point(82, 21);
            this.opcodeInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.opcodeInput.Name = "opcodeInput";
            this.opcodeInput.Size = new System.Drawing.Size(120, 23);
            this.opcodeInput.TabIndex = 4;
            // 
            // gmsCheckBox
            // 
            this.gmsCheckBox.AutoSize = true;
            this.gmsCheckBox.Location = new System.Drawing.Point(233, 22);
            this.gmsCheckBox.Name = "gmsCheckBox";
            this.gmsCheckBox.Size = new System.Drawing.Size(80, 19);
            this.gmsCheckBox.TabIndex = 3;
            this.gmsCheckBox.Text = "GMS (v12)";
            this.gmsCheckBox.UseVisualStyleBackColor = true;
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
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 15;
            this.resultListBox.Location = new System.Drawing.Point(12, 152);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(536, 199);
            this.resultListBox.TabIndex = 4;
            this.resultListBox.DoubleClick += new System.EventHandler(this.ResultListBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Find files";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.FindFilesClick);
            // 
            // label2
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(93, 127);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(38, 15);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "label2";
            this.statusLabel.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.SearchBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.SearchBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.SearchBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Finish);
            // 
            // progressBar1
            // 
            this.progressBar.Location = new System.Drawing.Point(445, 123);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 363);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.filtersGroupBox);
            this.Controls.Add(this.filesFoundLabel);
            this.Controls.Add(this.selectedPathTextBox);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Find MapleShark2 Sniffs";
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opcodeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox selectedPathTextBox;
        private Label filesFoundLabel;
        private GroupBox filtersGroupBox;
        private CheckBox gmsCheckBox;
        private CheckBox opCodeCheckBox;
        private ListBox resultListBox;
        private Button button2;
        private NumericUpDown opcodeInput;
        private ToolTip toolTip1;
        private Label statusLabel;
        private RadioButton checkBox1;
        private RadioButton InRadioButton;
        private RadioButton OutRadioButton;
        private System.ComponentModel.BackgroundWorker SearchBackgroundWorker;
        private ProgressBar progressBar;
    }
}