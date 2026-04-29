using System.Drawing;
using System.Windows.Forms;

namespace UniversityQuizSystem.Forms
{
    partial class ResultForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblName;
        private Label lblSubject;
        private Label lblScore;
        private Label lblGrade;
        private Label lblPercent;
        private Label lblFeedback;
        private Label lblSaved;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Text = "Quiz Result";
            this.Size = new Size(420, 420);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

            // Header
            pnlHeader = new Panel { BackColor = Color.FromArgb(25, 118, 210), Dock = DockStyle.Top, Height = 65 };
            lblTitle = new Label { Text = "🏆 Quiz Result", ForeColor = Color.White, Font = new Font("Segoe UI", 15, FontStyle.Bold), AutoSize = true, Location = new Point(20, 18) };
            pnlHeader.Controls.Add(lblTitle);

            // Big percentage display
            lblPercent = new Label
            {
                Text = "0%",
                Font = new Font("Segoe UI", 42, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 118, 210),
                AutoSize = true,
                Location = new Point(155, 80)
            };

            // Detail labels
            lblName    = new Label { Font = new Font("Segoe UI", 11), Location = new Point(40, 165), AutoSize = true };
            lblSubject = new Label { Font = new Font("Segoe UI", 11), Location = new Point(40, 193), AutoSize = true };
            lblScore   = new Label { Font = new Font("Segoe UI", 11, FontStyle.Bold), Location = new Point(40, 221), AutoSize = true };
            lblGrade   = new Label { Font = new Font("Segoe UI", 13, FontStyle.Bold), ForeColor = Color.FromArgb(25, 118, 210), Location = new Point(40, 252), AutoSize = true };

            // Feedback
            lblFeedback = new Label { Font = new Font("Segoe UI", 11, FontStyle.Bold), Location = new Point(40, 292), AutoSize = true };

            // Saved notice
            lblSaved = new Label { Text = "✔ Result saved to results.txt", Font = new Font("Segoe UI", 9, FontStyle.Italic), ForeColor = Color.Gray, Location = new Point(40, 320), AutoSize = true };

            // Close button
            btnClose = new Button
            {
                Text = "Close",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                BackColor = Color.FromArgb(25, 118, 210),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(120, 350),
                Size = new Size(160, 40)
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.Add(pnlHeader);
            this.Controls.Add(lblPercent);
            this.Controls.Add(lblName);
            this.Controls.Add(lblSubject);
            this.Controls.Add(lblScore);
            this.Controls.Add(lblGrade);
            this.Controls.Add(lblFeedback);
            this.Controls.Add(lblSaved);
            this.Controls.Add(btnClose);
        }
    }
}
