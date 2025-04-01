using System;
using System.Windows.Forms;

namespace quizGameProgrammesana_V1
{
    public partial class RegisterForm : Form
    {
        private DatabaseManager dbManager;

        public RegisterForm(DatabaseManager db)
        {
            InitializeComponent();
            dbManager = db;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (password != confirmPassword)
            {
                MessageBox.Show("Paroles nesakrīt!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dbManager.RegisterPlayer(username, password))
            {
                MessageBox.Show("Reģistrācija ir veiksmīga!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
