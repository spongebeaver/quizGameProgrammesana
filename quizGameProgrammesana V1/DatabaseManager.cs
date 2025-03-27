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
            SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=quiz.db;Version=3;");
            Connection = sQLiteConnection;
            Connection.Open();
        }
        public bool RegisterPlayer(string username, string password)
        {
            string checkUserQuery = "SELECT COUNT(*) FROM Players WHERE Name = @name";
            using (SQLiteCommand checkUserCmd = new SQLiteCommand(checkUserQuery, Connection))
            {
                checkUserCmd.Parameters.AddWithValue("@name", username);
                int count = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Lietotājvārds jau aizņemts!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            string insertUserQuery = "INSERT INTO Players (Name, Password, Score, Role) VALUES (@name, @password, 0, 'user')";
            using (SQLiteCommand insertUserCmd = new SQLiteCommand(insertUserQuery, Connection))
            {
                insertUserCmd.Parameters.AddWithValue("@name", username);
                insertUserCmd.Parameters.AddWithValue("@password", password);
                insertUserCmd.ExecuteNonQuery();
            }

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

        public bool IsAdmin(string username)
        {
            string query = "SELECT Role FROM Players WHERE Name = @name";
            using (SQLiteCommand cmd = new SQLiteCommand(query, Connection))
            {
                cmd.Parameters.AddWithValue("@name", username);
                object result = cmd.ExecuteScalar();
                return result != null && result.ToString().ToLower() == "admin";
            }
        }
    }
}
