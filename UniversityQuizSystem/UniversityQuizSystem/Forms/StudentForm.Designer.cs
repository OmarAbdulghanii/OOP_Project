using System.Drawing;
using System.Windows.Forms;

namespace UniversityQuizSystem.Forms
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblInfo;
        private Label lblProgress;
        private Label lblQuestion;
        private Label lblAnswerType;
        private Panel pnlMCQ;
        private RadioButton rbA, rbB, rbC, rbD;
        private Panel pnlEssay;
        private TextBox txtEssay;
        private Button btnPrev;
        private Button btnNext;
        private Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Text = "University Quiz System - Take Quiz";
            this.Size = new Size(680, 520);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Header
            pnlHeader = new Panel { BackColor = Color.FromArgb(56, 142, 60), Dock = DockStyle.Top, Height = 65 };
            lblTitle = new Label { Text = "📋 Student Quiz", ForeColor = Color.White, Font = new Font("Segoe UI", 15, FontStyle.Bold), AutoSize = true, Location = new Point(20, 8) };
            lblInfo = new Label { ForeColor = Color.LightGreen, Font = new Font("Segoe UI", 9), AutoSize = true, Location = new Point(20, 40) };
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblInfo);

            // Progress
            lblProgress = new Label { Text = "Question 1 of 1", Font = new Font("Segoe UI", 9, FontStyle.Italic), ForeColor = Color.Gray, Location = new Point(20, 80), AutoSize = true };

            // Question text
            lblQuestion = new Label
            {
                Text = "",
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 30, 30),
                Location = new Point(20, 108),
                Size = new Size(630, 80),
                MaximumSize = new Size(630, 0),
                AutoSize = true
            };

            lblAnswerType = new Label { Text = "", Font = new Font("Segoe UI", 9, FontStyle.Italic), ForeColor = Color.SlateGray, Location = new Point(20, 200), AutoSize = true };

            // MCQ Panel
            pnlMCQ = new Panel { Location = new Point(20, 220), Size = new Size(620, 160), Visible = false };
            rbA = new RadioButton { Font = new Font("Segoe UI", 11), Location = new Point(0, 0), Size = new Size(580, 30), AutoSize = false };
            rbB = new RadioButton { Font = new Font("Segoe UI", 11), Location = new Point(0, 35), Size = new Size(580, 30), AutoSize = false };
            rbC = new RadioButton { Font = new Font("Segoe UI", 11), Location = new Point(0, 70), Size = new Size(580, 30), AutoSize = false };
            rbD = new RadioButton { Font = new Font("Segoe UI", 11), Location = new Point(0, 105), Size = new Size(580, 30), AutoSize = false };
            pnlMCQ.Controls.Add(rbA);
            pnlMCQ.Controls.Add(rbB);
            pnlMCQ.Controls.Add(rbC);
            pnlMCQ.Controls.Add(rbD);

            // Essay Panel
            pnlEssay = new Panel { Location = new Point(20, 220), Size = new Size(620, 160), Visible = false };
            txtEssay = new TextBox { Font = new Font("Segoe UI", 10), Location = new Point(0, 0), Size = new Size(618, 155), Multiline = true, ScrollBars = ScrollBars.Vertical };
            pnlEssay.Controls.Add(txtEssay);

            // Navigation Buttons
            btnPrev = new Button { Text = "◀ Previous", Font = new Font("Segoe UI", 10), BackColor = Color.Gray, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(20, 410), Size = new Size(130, 40) };
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.Click += new System.EventHandler(this.btnPrev_Click);

            btnNext = new Button { Text = "Next ▶", Font = new Font("Segoe UI", 10), BackColor = Color.FromArgb(25, 118, 210), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(165, 410), Size = new Size(130, 40) };
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.Click += new System.EventHandler(this.btnNext_Click);

            btnSubmit = new Button { Text = "✅ Submit Quiz", Font = new Font("Segoe UI", 11, FontStyle.Bold), BackColor = Color.FromArgb(56, 142, 60), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(460, 410), Size = new Size(180, 40) };
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.Controls.Add(pnlHeader);
            this.Controls.Add(lblProgress);
            this.Controls.Add(lblQuestion);
            this.Controls.Add(lblAnswerType);
            this.Controls.Add(pnlMCQ);
            this.Controls.Add(pnlEssay);
            this.Controls.Add(btnPrev);
            this.Controls.Add(btnNext);
            this.Controls.Add(btnSubmit);
        }
    }
}
