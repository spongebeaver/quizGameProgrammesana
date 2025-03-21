using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace quizGameProgrammesana_V1
{
    public class DatabaseManager
    {
        public SQLiteConnection Connection { get; private set; }

        public DatabaseManager(string databasePath)
        {
            string folderPath = Path.GetDirectoryName(databasePath);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(databasePath))
            {
                SQLiteConnection.CreateFile(databasePath);
            }

            Connection = new SQLiteConnection($"Data Source={databasePath};Version=3;");
            Connection.Open();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            string createPlayersTable = @"CREATE TABLE IF NOT EXISTS Players (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT UNIQUE NOT NULL,
                Password TEXT NOT NULL,
                Score INTEGER DEFAULT 0
            );";

            string createQuestionsTable = @"CREATE TABLE IF NOT EXISTS Questions (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Question TEXT NOT NULL,
                Option1 TEXT NOT NULL,
                Option2 TEXT NOT NULL,
                Option3 TEXT NOT NULL,
                Option4 TEXT NOT NULL,
                CorrectOption INTEGER NOT NULL
            );";

            SQLiteCommand cmd1 = new SQLiteCommand(createPlayersTable, Connection);
            SQLiteCommand cmd2 = new SQLiteCommand(createQuestionsTable, Connection);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
        }

        public bool RegisterPlayer(string username, string password)
        {
            string checkUserQuery = "SELECT COUNT(*) FROM Players WHERE Name = @name";
            SQLiteCommand checkUserCmd = new SQLiteCommand(checkUserQuery, Connection);
            checkUserCmd.Parameters.AddWithValue("@name", username);
            int count = Convert.ToInt32(checkUserCmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Lietotājvārds jau aizņemts!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string insertUserQuery = "INSERT INTO Players (Name, Password) VALUES (@name, @password)";
            SQLiteCommand insertUserCmd = new SQLiteCommand(insertUserQuery, Connection);
            insertUserCmd.Parameters.AddWithValue("@name", username);
            insertUserCmd.Parameters.AddWithValue("@password", password);
            insertUserCmd.ExecuteNonQuery();

            return true;
        }

        public bool LoginPlayer(string username, string password)
        {
            string checkUserQuery = "SELECT Password FROM Players WHERE Name = @name";
            SQLiteCommand checkUserCmd = new SQLiteCommand(checkUserQuery, Connection);
            checkUserCmd.Parameters.AddWithValue("@name", username);
            SQLiteDataReader reader = checkUserCmd.ExecuteReader();

            if (reader.Read())
            {
                string storedPassword = reader.GetString(0);
                reader.Close();
                return storedPassword == password;
            }

            reader.Close();
            return false;
        }
    }
}
