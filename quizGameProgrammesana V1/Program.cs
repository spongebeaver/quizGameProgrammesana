using System;
using System.Windows.Forms;

namespace quizGameProgrammesana_V1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseManager dbManager = new DatabaseManager("Data/quiz.db");

            LoginForm loginForm = new LoginForm(dbManager);
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new TestForm(dbManager, loginForm.Username));
            }
        }
    }
}
