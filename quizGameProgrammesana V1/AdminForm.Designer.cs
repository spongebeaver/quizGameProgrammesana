namespace quizGameProgrammesana_V1
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            listBoxQuestions = new ListBox();
            label3 = new Label();
            label4 = new Label();
            txtQuestion = new TextBox();
            txtOption1 = new TextBox();
            txtOption2 = new TextBox();
            label5 = new Label();
            txtOption3 = new TextBox();
            label6 = new Label();
            txtOption4 = new TextBox();
            label7 = new Label();
            comboCorrect = new ComboBox();
            btnAddQuestion = new Button();
            btnDeleteQuestion = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(291, 19);
            label1.TabIndex = 5;
            label1.Text = "Jautājumu modifikācijas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(636, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 19);
            label2.TabIndex = 6;
            label2.Text = "Jautājums:";
            // 
            // listBoxQuestions
            // 
            listBoxQuestions.FormattingEnabled = true;
            listBoxQuestions.ItemHeight = 19;
            listBoxQuestions.Location = new Point(14, 56);
            listBoxQuestions.Margin = new Padding(4, 2, 4, 2);
            listBoxQuestions.Name = "listBoxQuestions";
            listBoxQuestions.Size = new Size(596, 384);
            listBoxQuestions.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(636, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 8;
            label3.Text = "Atbilde 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(636, 185);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 19);
            label4.TabIndex = 9;
            label4.Text = "Atbilde 2:";
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(636, 56);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(286, 26);
            txtQuestion.TabIndex = 10;
            // 
            // txtOption1
            // 
            txtOption1.Location = new Point(636, 144);
            txtOption1.Name = "txtOption1";
            txtOption1.Size = new Size(286, 26);
            txtOption1.TabIndex = 11;
            // 
            // txtOption2
            // 
            txtOption2.Location = new Point(636, 223);
            txtOption2.Name = "txtOption2";
            txtOption2.Size = new Size(286, 26);
            txtOption2.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(636, 266);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 13;
            label5.Text = "Atbilde 3:";
            // 
            // txtOption3
            // 
            txtOption3.Location = new Point(636, 300);
            txtOption3.Name = "txtOption3";
            txtOption3.Size = new Size(286, 26);
            txtOption3.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(636, 343);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 19);
            label6.TabIndex = 15;
            label6.Text = "Atbilde 4:";
            // 
            // txtOption4
            // 
            txtOption4.Location = new Point(636, 378);
            txtOption4.Name = "txtOption4";
            txtOption4.Size = new Size(286, 26);
            txtOption4.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(636, 422);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(210, 19);
            label7.TabIndex = 17;
            label7.Text = "Pareizā atbilde::";
            // 
            // comboCorrect
            // 
            comboCorrect.FormattingEnabled = true;
            comboCorrect.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboCorrect.Location = new Point(636, 455);
            comboCorrect.Name = "comboCorrect";
            comboCorrect.Size = new Size(182, 27);
            comboCorrect.TabIndex = 18;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Location = new Point(14, 476);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(310, 34);
            btnAddQuestion.TabIndex = 19;
            btnAddQuestion.Text = "Pievienot jautājumu";
            btnAddQuestion.UseVisualStyleBackColor = true;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // btnDeleteQuestion
            // 
            btnDeleteQuestion.Location = new Point(14, 529);
            btnDeleteQuestion.Name = "btnDeleteQuestion";
            btnDeleteQuestion.Size = new Size(310, 34);
            btnDeleteQuestion.TabIndex = 20;
            btnDeleteQuestion.Text = "Dzēst jautājumu";
            btnDeleteQuestion.UseVisualStyleBackColor = true;
            btnDeleteQuestion.Click += btnDeleteQuestion_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 582);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(149, 34);
            btnClose.TabIndex = 21;
            btnClose.Text = "Aizvērt";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(12F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 128, 129);
            ClientSize = new Size(958, 744);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteQuestion);
            Controls.Add(btnAddQuestion);
            Controls.Add(comboCorrect);
            Controls.Add(label7);
            Controls.Add(txtOption4);
            Controls.Add(label6);
            Controls.Add(txtOption3);
            Controls.Add(label5);
            Controls.Add(txtOption2);
            Controls.Add(txtOption1);
            Controls.Add(txtQuestion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBoxQuestions);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 2, 4, 2);
            Name = "AdminForm";
            Text = "Matemātikas tests";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBoxQuestions;
        private Label label3;
        private Label label4;
        private TextBox txtQuestion;
        private TextBox txtOption1;
        private TextBox txtOption2;
        private Label label5;
        private TextBox txtOption3;
        private Label label6;
        private TextBox txtOption4;
        private Label label7;
        private ComboBox comboCorrect;
        private Button btnAddQuestion;
        private Button btnDeleteQuestion;
        private Button btnClose;
    }
}