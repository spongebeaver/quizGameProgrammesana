using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace quizGameProgrammesana_V1
{
    public partial class AdminForm : Form
    {
        private SQLiteConnection connection;

        public AdminForm()
        {
            InitializeComponent();
            connection = new SQLiteConnection("Data Source=quiz.db;Version=3;");
            connection.Open();
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            listBoxQuestions.Items.Clear();
            string query = "SELECT Id, QuestionText FROM Questions";

            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string questionText = reader.GetString(1);
                    listBoxQuestions.Items.Add($"{id}: {questionText}");
                }
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text) ||
                string.IsNullOrWhiteSpace(txtOption1.Text) ||
                string.IsNullOrWhiteSpace(txtOption2.Text) ||
                string.IsNullOrWhiteSpace(txtOption3.Text) ||
                string.IsNullOrWhiteSpace(txtOption4.Text) ||
                comboCorrect.SelectedIndex == -1)
            {
                MessageBox.Show("Lūdzu, aizpildiet visus laukus!", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Questions (QuestionText, Option1, Option2, Option3, Option4, CorrectOption) " +
                           "VALUES (@qText, @opt1, @opt2, @opt3, @opt4, @correctOpt)";

            using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@qText", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@opt1", txtOption1.Text);
                cmd.Parameters.AddWithValue("@opt2", txtOption2.Text);
                cmd.Parameters.AddWithValue("@opt3", txtOption3.Text);
                cmd.Parameters.AddWithValue("@opt4", txtOption4.Text);
                cmd.Parameters.AddWithValue("@correctOpt", comboCorrect.SelectedIndex + 1);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Jautājums pievienots!", "Veiksmīgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadQuestions();
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem == null)
            {
                MessageBox.Show("Lūdzu, izvēlieties jautājumu dzēšanai!", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = listBoxQuestions.SelectedItem.ToString();
            int questionId = int.Parse(selectedItem.Split(':')[0]);

            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    string deleteQuery = "DELETE FROM Questions WHERE Id = @id";
                    using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", questionId);
                        cmd.ExecuteNonQuery();
                    }

                    string getMaxIdQuery = "SELECT MAX(Id) FROM Questions";
                    int newMaxId = 0;
                    using (SQLiteCommand getMaxIdCmd = new SQLiteCommand(getMaxIdQuery, connection))
                    {
                        object result = getMaxIdCmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            newMaxId = Convert.ToInt32(result);
                        }
                    }

                    string resetAutoIncrementQuery = "UPDATE sqlite_sequence SET seq = @newMaxId WHERE name = 'Questions'";
                    using (SQLiteCommand resetCmd = new SQLiteCommand(resetAutoIncrementQuery, connection))
                    {
                        resetCmd.Parameters.AddWithValue("@newMaxId", newMaxId);
                        resetCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Jautājums dzēsts!", "Veiksmīgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadQuestions();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Kļūda dzēšot jautājumu: " + ex.Message, "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

