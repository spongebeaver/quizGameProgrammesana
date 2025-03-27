using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace quizGameProgrammesana_V1
{
    public partial class LeaderboardForm : Form
    {
        public LeaderboardForm()
        {
            InitializeComponent();
            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            listBoxLeaderboard.Items.Clear();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=quiz.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT Name, Score FROM Players ORDER BY Score DESC LIMIT 10";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBoxLeaderboard.Items.Add($"{reader["Name"]} - {reader["Score"]} points");
                        }
                    }
                }
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
