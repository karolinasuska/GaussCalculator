namespace GaussCalculator
{
    partial class Form1
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
            title = new Label();
            fileContentsTextBox = new RichTextBox();
            resultsTextBox = new RichTextBox();
            calculateButton = new Button();
            chooseFileButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            cCheckBox = new CheckBox();
            asmCheckBox = new CheckBox();
            libraryMenu = new Label();
            threadTrackBar = new TrackBar();
            threadsMenu = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cTime = new TextBox();
            asmTime = new TextBox();
            timesLabel = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)threadTrackBar).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            title.ForeColor = SystemColors.ControlLight;
            title.Location = new Point(401, 45);
            title.Name = "title";
            title.Size = new Size(394, 65);
            title.TabIndex = 0;
            title.Text = "Gauss calculator";
            // 
            // fileContentsTextBox
            // 
            fileContentsTextBox.BackColor = SystemColors.ScrollBar;
            fileContentsTextBox.Location = new Point(44, 161);
            fileContentsTextBox.Name = "fileContentsTextBox";
            fileContentsTextBox.Size = new Size(547, 306);
            fileContentsTextBox.TabIndex = 1;
            fileContentsTextBox.Text = "";
            // 
            // resultsTextBox
            // 
            resultsTextBox.BackColor = SystemColors.ScrollBar;
            resultsTextBox.Location = new Point(748, 161);
            resultsTextBox.Name = "resultsTextBox";
            resultsTextBox.Size = new Size(381, 306);
            resultsTextBox.TabIndex = 2;
            resultsTextBox.Text = "";
            // 
            // calculateButton
            // 
            calculateButton.BackColor = SystemColors.ScrollBar;
            calculateButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            calculateButton.ForeColor = SystemColors.ControlDarkDark;
            calculateButton.Location = new Point(624, 235);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(95, 40);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // chooseFileButton
            // 
            chooseFileButton.BackColor = SystemColors.ScrollBar;
            chooseFileButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            chooseFileButton.ForeColor = SystemColors.ControlDarkDark;
            chooseFileButton.Location = new Point(624, 348);
            chooseFileButton.Name = "chooseFileButton";
            chooseFileButton.Size = new Size(95, 42);
            chooseFileButton.TabIndex = 4;
            chooseFileButton.Text = "Choose file";
            chooseFileButton.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // cCheckBox
            // 
            cCheckBox.AutoSize = true;
            cCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cCheckBox.ForeColor = SystemColors.ControlDarkDark;
            cCheckBox.Location = new Point(100, 557);
            cCheckBox.Name = "cCheckBox";
            cCheckBox.Size = new Size(48, 25);
            cCheckBox.TabIndex = 5;
            cCheckBox.Text = "C#";
            cCheckBox.UseVisualStyleBackColor = true;
            // 
            // asmCheckBox
            // 
            asmCheckBox.AutoSize = true;
            asmCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            asmCheckBox.ForeColor = SystemColors.ControlDarkDark;
            asmCheckBox.Location = new Point(100, 604);
            asmCheckBox.Name = "asmCheckBox";
            asmCheckBox.Size = new Size(62, 25);
            asmCheckBox.TabIndex = 6;
            asmCheckBox.Text = "Asm";
            asmCheckBox.UseVisualStyleBackColor = true;
            // 
            // libraryMenu
            // 
            libraryMenu.AutoSize = true;
            libraryMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            libraryMenu.ForeColor = SystemColors.ControlDarkDark;
            libraryMenu.Location = new Point(79, 513);
            libraryMenu.Name = "libraryMenu";
            libraryMenu.Size = new Size(130, 21);
            libraryMenu.TabIndex = 7;
            libraryMenu.Text = "Selected library";
            // 
            // threadTrackBar
            // 
            threadTrackBar.BackColor = SystemColors.ControlDark;
            threadTrackBar.Location = new Point(309, 557);
            threadTrackBar.Maximum = 7;
            threadTrackBar.Minimum = 1;
            threadTrackBar.Name = "threadTrackBar";
            threadTrackBar.Size = new Size(282, 45);
            threadTrackBar.TabIndex = 8;
            threadTrackBar.Value = 1;
            // 
            // threadsMenu
            // 
            threadsMenu.AutoSize = true;
            threadsMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            threadsMenu.ForeColor = SystemColors.ControlDarkDark;
            threadsMenu.Location = new Point(379, 513);
            threadsMenu.Name = "threadsMenu";
            threadsMenu.Size = new Size(154, 21);
            threadsMenu.TabIndex = 9;
            threadsMenu.Text = "Number of threads";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(309, 605);
            label1.Name = "label1";
            label1.Size = new Size(19, 21);
            label1.TabIndex = 10;
            label1.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(356, 605);
            label2.Name = "label2";
            label2.Size = new Size(19, 21);
            label2.TabIndex = 11;
            label2.Text = "2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(398, 605);
            label3.Name = "label3";
            label3.Size = new Size(19, 21);
            label3.TabIndex = 12;
            label3.Text = "4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(441, 605);
            label4.Name = "label4";
            label4.Size = new Size(19, 21);
            label4.TabIndex = 13;
            label4.Text = "8";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(478, 605);
            label5.Name = "label5";
            label5.Size = new Size(28, 21);
            label5.TabIndex = 14;
            label5.Text = "16";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(522, 605);
            label6.Name = "label6";
            label6.Size = new Size(28, 21);
            label6.TabIndex = 15;
            label6.Text = "32";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(563, 604);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 16;
            label7.Text = "64";
            // 
            // cTime
            // 
            cTime.BackColor = SystemColors.ScrollBar;
            cTime.Location = new Point(773, 589);
            cTime.Name = "cTime";
            cTime.Size = new Size(125, 23);
            cTime.TabIndex = 17;
            // 
            // asmTime
            // 
            asmTime.BackColor = SystemColors.ScrollBar;
            asmTime.Location = new Point(977, 589);
            asmTime.Name = "asmTime";
            asmTime.Size = new Size(125, 23);
            asmTime.TabIndex = 18;
            // 
            // timesLabel
            // 
            timesLabel.AutoSize = true;
            timesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            timesLabel.ForeColor = SystemColors.ControlDarkDark;
            timesLabel.Location = new Point(868, 513);
            timesLabel.Name = "timesLabel";
            timesLabel.Size = new Size(136, 21);
            timesLabel.TabIndex = 19;
            timesLabel.Text = "Calculation time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(823, 558);
            label8.Name = "label8";
            label8.Size = new Size(29, 21);
            label8.TabIndex = 20;
            label8.Text = "C#";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(1020, 557);
            label9.Name = "label9";
            label9.Size = new Size(43, 21);
            label9.TabIndex = 21;
            label9.Text = "Asm";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(44, 143);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 22;
            label10.Text = "File contents";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(748, 143);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 23;
            label11.Text = "Results";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1182, 677);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(timesLabel);
            Controls.Add(asmTime);
            Controls.Add(cTime);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(threadsMenu);
            Controls.Add(threadTrackBar);
            Controls.Add(libraryMenu);
            Controls.Add(asmCheckBox);
            Controls.Add(cCheckBox);
            Controls.Add(chooseFileButton);
            Controls.Add(calculateButton);
            Controls.Add(resultsTextBox);
            Controls.Add(fileContentsTextBox);
            Controls.Add(title);
            Name = "Form1";
            Text = "Gauss calculator";
            ((System.ComponentModel.ISupportInitialize)threadTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private RichTextBox fileContentsTextBox;
        private RichTextBox resultsTextBox;
        private Button calculateButton;
        private Button chooseFileButton;
        private OpenFileDialog openFileDialog1;
        private CheckBox cCheckBox;
        private CheckBox asmCheckBox;
        private Label libraryMenu;
        private TrackBar threadTrackBar;
        private Label threadsMenu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox cTime;
        private TextBox asmTime;
        private Label timesLabel;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
