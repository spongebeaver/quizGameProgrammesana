using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizGameProgrammesana_V1
{
    partial class RegisterForm
    {
        private void InitializeComponent()
        {
            btnRegister = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.ActiveCaptionText;
            btnRegister.Location = new Point(12, 354);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(142, 34);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(232, 26);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(232, 26);
            txtPassword.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(12, 256);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(232, 26);
            txtConfirmPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 7;
            label2.Text = "Parole";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(159, 19);
            label1.TabIndex = 6;
            label1.Text = "Lietotājvārds";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 228);
            label3.Name = "label3";
            label3.Size = new Size(237, 19);
            label3.TabIndex = 8;
            label3.Text = "Apstipriniet paroli";
            // 
            // RegisterForm
            // 
            BackColor = Color.FromArgb(0, 128, 129);
            ClientSize = new Size(417, 424);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnRegister);
            Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "RegisterForm";
            Text = "Matemātikas tests";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnRegister;
    }
}
