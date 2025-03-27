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

                if (dbManager.IsAdmin(username))
                {
                    MessageBox.Show($"Sveicināts, {username}! Jūs esat administrators.", "Piekļuve admin panelim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Nederīgs lietotājvārds vai parole!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(dbManager);
            registerForm.ShowDialog();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            LeaderboardForm leaderboardForm = new LeaderboardForm();
            leaderboardForm.ShowDialog();
        }
    }
}

