namespace quizGameProgrammesana_V1
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
            questionLabel = new Label();
            lblQuestion = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            rbtnOption1 = new RadioButton();
            rbtnOption2 = new RadioButton();
            rbtnOption3 = new RadioButton();
            rbtnOption4 = new RadioButton();
            btnNext = new Button();
            lblCurrentQuestion = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(30, 48);
            questionLabel.Margin = new Padding(8, 0, 8, 0);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(212, 35);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "Jautājums:";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(223, 48);
            lblQuestion.Margin = new Padding(8, 0, 8, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(0, 35);
            lblQuestion.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // rbtnOption1
            // 
            rbtnOption1.AutoSize = true;
            rbtnOption1.Location = new Point(30, 190);
            rbtnOption1.Margin = new Padding(8, 6, 8, 6);
            rbtnOption1.Name = "rbtnOption1";
            rbtnOption1.Size = new Size(200, 39);
            rbtnOption1.TabIndex = 2;
            rbtnOption1.TabStop = true;
            rbtnOption1.Text = "Option 1";
            rbtnOption1.UseVisualStyleBackColor = true;
            // 
            // rbtnOption2
            // 
            rbtnOption2.AutoSize = true;
            rbtnOption2.Location = new Point(30, 241);
            rbtnOption2.Margin = new Padding(8, 6, 8, 6);
            rbtnOption2.Name = "rbtnOption2";
            rbtnOption2.Size = new Size(200, 39);
            rbtnOption2.TabIndex = 3;
            rbtnOption2.TabStop = true;
            rbtnOption2.Text = "Option 2";
            rbtnOption2.UseVisualStyleBackColor = true;
            // 
            // rbtnOption3
            // 
            rbtnOption3.AutoSize = true;
            rbtnOption3.Location = new Point(30, 295);
            rbtnOption3.Margin = new Padding(8, 6, 8, 6);
            rbtnOption3.Name = "rbtnOption3";
            rbtnOption3.Size = new Size(200, 39);
            rbtnOption3.TabIndex = 4;
            rbtnOption3.TabStop = true;
            rbtnOption3.Text = "Option 3";
            rbtnOption3.UseVisualStyleBackColor = true;
            // 
            // rbtnOption4
            // 
            rbtnOption4.AutoSize = true;
            rbtnOption4.Location = new Point(30, 346);
            rbtnOption4.Margin = new Padding(8, 6, 8, 6);
            rbtnOption4.Name = "rbtnOption4";
            rbtnOption4.Size = new Size(200, 39);
            rbtnOption4.TabIndex = 5;
            rbtnOption4.TabStop = true;
            rbtnOption4.Text = "Option 4";
            rbtnOption4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.ForeColor = SystemColors.ActiveCaptionText;
            btnNext.Location = new Point(30, 464);
            btnNext.Margin = new Padding(8, 6, 8, 6);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(517, 70);
            btnNext.TabIndex = 6;
            btnNext.Text = "Nakamais jautājums";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblCurrentQuestion
            // 
            lblCurrentQuestion.AutoSize = true;
            lblCurrentQuestion.Location = new Point(30, 553);
            lblCurrentQuestion.Margin = new Padding(8, 0, 8, 0);
            lblCurrentQuestion.Name = "lblCurrentQuestion";
            lblCurrentQuestion.Size = new Size(0, 35);
            lblCurrentQuestion.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 128, 129);
            ClientSize = new Size(1303, 787);
            Controls.Add(lblCurrentQuestion);
            Controls.Add(btnNext);
            Controls.Add(rbtnOption4);
            Controls.Add(rbtnOption3);
            Controls.Add(rbtnOption2);
            Controls.Add(rbtnOption1);
            Controls.Add(lblQuestion);
            Controls.Add(questionLabel);
            Font = new Font("OCR A Extended", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(8, 6, 8, 6);
            Name = "Form1";
            Text = "Matemātikas tests";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionLabel;
        private Label lblQuestion;
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnNext;
        private RadioButton rbtnOption4;
        private RadioButton rbtnOption3;
        private RadioButton rbtnOption2;
        private RadioButton rbtnOption1;
        private Label lblCurrentQuestion;
    }
}