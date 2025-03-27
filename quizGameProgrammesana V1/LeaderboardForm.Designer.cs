using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizGameProgrammesana_V1
{
    partial class LeaderboardForm
    {
        private void InitializeComponent()
        {
            label1 = new Label();
            btnBack = new Button();
            listBoxLeaderboard = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(210, 19);
            label1.TabIndex = 4;
            label1.Text = "Rezultātu tabula:";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(23, 275);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(142, 34);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // listBoxLeaderboard
            // 
            listBoxLeaderboard.FormattingEnabled = true;
            listBoxLeaderboard.ItemHeight = 19;
            listBoxLeaderboard.Location = new Point(23, 74);
            listBoxLeaderboard.Name = "listBoxLeaderboard";
            listBoxLeaderboard.Size = new Size(295, 137);
            listBoxLeaderboard.TabIndex = 7;
            // 
            // LeaderboardForm
            // 
            BackColor = Color.FromArgb(0, 128, 129);
            ClientSize = new Size(557, 331);
            Controls.Add(listBoxLeaderboard);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "LeaderboardForm";
            Text = "Matemātikas tests";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Button btnBack;
        private ListBox listBoxLeaderboard;
    }
}
