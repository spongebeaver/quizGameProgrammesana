using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace quizGameProgrammesana_V1
{
    public partial class Form1 : Form
    {
        private SQLiteConnection connection;
        private List<int> selectedQuestionIds = new List<int>();
        private int totalQuestions = 10;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private string username;

        public Form1(DatabaseManager dbManager)
        {
            InitializeComponent();

            connection = new SQLiteConnection("Data Source=quiz.db;Version=3;");
            connection.Open();

            LoadRandomQuestions();

            if (selectedQuestionIds.Count > 0)
            {
                LoadQuestion(selectedQuestionIds[currentQuestionIndex]);
            }
            else
            {
                MessageBox.Show("Datubāzē nav pieejami jautājumi.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public Form1(DatabaseManager dbManager, string username) : this(dbManager)
        {
            this.username = username;
        }

        private void LoadRandomQuestions()
        {
            SQLiteCommand command = new SQLiteCommand("SELECT Id FROM Questions", connection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<int> questionIds = new List<int>();
            while (reader.Read())
            {
                questionIds.Add(reader.GetInt32(0));
            }
            reader.Close();

            Random random = new Random();
            while (selectedQuestionIds.Count < totalQuestions)
            {
                int randomId = questionIds[random.Next(questionIds.Count)];
                if (!selectedQuestionIds.Contains(randomId))
                {
                    selectedQuestionIds.Add(randomId);
                }
            }
        }

        private void LoadQuestion(int questionId)
        {
            SQLiteCommand command = new SQLiteCommand("SELECT QuestionText, Option1, Option2, Option3, Option4, CorrectOption FROM Questions WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", questionId);

            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                lblQuestion.Text = reader.GetString(0);

                rbtnOption1.Text = reader.GetString(1);
                rbtnOption2.Text = reader.GetString(2);
                rbtnOption3.Text = reader.GetString(3);
                rbtnOption4.Text = reader.GetString(4);

                int correctOption = reader.GetInt32(5);
                rbtnOption1.Tag = (correctOption == 1);
                rbtnOption2.Tag = (correctOption == 2);
                rbtnOption3.Tag = (correctOption == 3);
                rbtnOption4.Tag = (correctOption == 4);

                rbtnOption1.Checked = false;
                rbtnOption2.Checked = false;
                rbtnOption3.Checked = false;
                rbtnOption4.Checked = false;
            }
            reader.Close();
        }
        private void numberLabel_Click(object sender, EventArgs e)
        {

        }
        private void ShowFinalResult()
        {
            string message = $"Tests ir pabeigts!\nJūsu rezultāts: {score}/{totalQuestions}";
            MessageBox.Show(message, "Rezultāts");

            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!rbtnOption1.Checked && !rbtnOption2.Checked && !rbtnOption3.Checked && !rbtnOption4.Checked)
            {
                MessageBox.Show("Lūdzu, atlasiet atbildi, pirms pāriet pie nākamā jautājuma.", "Uzmanīgi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isCorrect = (rbtnOption1.Checked && rbtnOption1.Tag != null && (bool)rbtnOption1.Tag) ||
                             (rbtnOption2.Checked && rbtnOption2.Tag != null && (bool)rbtnOption2.Tag) ||
                             (rbtnOption3.Checked && rbtnOption3.Tag != null && (bool)rbtnOption3.Tag) ||
                             (rbtnOption4.Checked && rbtnOption4.Tag != null && (bool)rbtnOption4.Tag);

            if (isCorrect)
            {
                score++;
                MessageBox.Show("Pareizi!", "Rezultāts", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nepareizi!", "Rezultāts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            currentQuestionIndex++;

            if (currentQuestionIndex < totalQuestions)
            {
                LoadQuestion(selectedQuestionIds[currentQuestionIndex]);
            }
            else
            {
                ShowFinalResult();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRandomQuestions();
            LoadQuestion(selectedQuestionIds[currentQuestionIndex]);
        }
    }
}