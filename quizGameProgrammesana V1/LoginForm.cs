using System;
using System.Windows.Forms;

namespace quizGameProgrammesana_V1
{
    public partial class LoginForm : Form
    {
        private DatabaseManager dbManager;
        public string Username { get; private set; }

        public LoginForm(DatabaseManager db)
        {
            InitializeComponent();
            dbManager = db;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (dbManager.LoginPlayer(username, password))
            {
                Username = username;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Nederīgs lietotājvārds vai parole!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnRegister = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(12, 247);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // btnRegister
            // 
            btnRegister.ForeColor = SystemColors.ActiveCaptionText;
            btnRegister.Location = new Point(163, 247);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(154, 34);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(232, 26);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(232, 26);
            txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(159, 19);
            label1.TabIndex = 4;
            label1.Text = "Lietotājvārds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 5;
            label2.Text = "Parole";
            // 
            // LoginForm
            // 
            BackColor = Color.FromArgb(0, 128, 129);
            ClientSize = new Size(557, 331);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnRegister;

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(dbManager);
            registerForm.ShowDialog();
        }
    }
}
