using System.Drawing;
using System.Windows.Forms;

namespace UniversityQuizSystem.Forms
{
    partial class LecturerForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblInfo;
        private Label lblQuestion;
        private TextBox txtQuestion;
        private Label lblType;
        private ComboBox cmbType;
        private Panel pnlMCQ;
        private Label lblOptA, lblOptB, lblOptC, lblOptD, lblAnswer;
        private TextBox txtOptA, txtOptB, txtOptC, txtOptD;
        private ComboBox cmbAnswer;
        private Button btnAdd;
        private Button btnSave;
        private Button btnLogout;
        private ListBox lstQuestions;
        private Label lblCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Text = "University Quiz System - Lecturer Panel";
            this.Size = new Size(800, 620);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Header
            pnlHeader = new Panel { BackColor = Color.FromArgb(25, 118, 210), Dock = DockStyle.Top, Height = 65 };
            lblTitle = new Label { Text = "📝 Lecturer Panel", ForeColor = Color.White, Font = new Font("Segoe UI", 15, FontStyle.Bold), AutoSize = true, Location = new Point(20, 8) };
            lblInfo = new Label { ForeColor = Color.LightCyan, Font = new Font("Segoe UI", 9), AutoSize = true, Location = new Point(20, 40) };
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblInfo);

            // Question text
            lblQuestion = new Label { Text = "Question Text:", Font = new Font("Segoe UI", 10), Location = new Point(20, 85), AutoSize = true };
            txtQuestion = new TextBox { Font = new Font("Segoe UI", 10), Location = new Point(20, 107), Size = new Size(460, 28), Multiline = false };

            // Question type
            lblType = new Label { Text = "Question Type:", Font = new Font("Segoe UI", 10), Location = new Point(20, 148), AutoSize = true };
            cmbType = new ComboBox { Font = new Font("Segoe UI", 10), Location = new Point(160, 145), Size = new Size(200, 28), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbType.Items.AddRange(new string[] { "Multiple Choice", "Essay" });
            cmbType.SelectedIndex = 0;
            cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);

            // MCQ panel
            pnlMCQ = new Panel { Location = new Point(20, 185), Size = new Size(480, 165), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.FromArgb(245, 248, 255) };

            lblOptA = new Label { Text = "A:", Font = new Font("Segoe UI", 9), Location = new Point(8, 12), AutoSize = true };
            txtOptA = new TextBox { Font = new Font("Segoe UI", 9), Location = new Point(30, 9), Size = new Size(420, 24) };

            lblOptB = new Label { Text = "B:", Font = new Font("Segoe UI", 9), Location = new Point(8, 42), AutoSize = true };
            txtOptB = new TextBox { Font = new Font("Segoe UI", 9), Location = new Point(30, 39), Size = new Size(420, 24) };

            lblOptC = new Label { Text = "C:", Font = new Font("Segoe UI", 9), Location = new Point(8, 72), AutoSize = true };
            txtOptC = new TextBox { Font = new Font("Segoe UI", 9), Location = new Point(30, 69), Size = new Size(420, 24) };

            lblOptD = new Label { Text = "D:", Font = new Font("Segoe UI", 9), Location = new Point(8, 102), AutoSize = true };
            txtOptD = new TextBox { Font = new Font("Segoe UI", 9), Location = new Point(30, 99), Size = new Size(420, 24) };

            lblAnswer = new Label { Text = "Correct Answer:", Font = new Font("Segoe UI", 9), Location = new Point(8, 133), AutoSize = true };
            cmbAnswer = new ComboBox { Font = new Font("Segoe UI", 9), Location = new Point(120, 130), Size = new Size(80, 24), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbAnswer.Items.AddRange(new string[] { "A", "B", "C", "D" });

            pnlMCQ.Controls.Add(lblOptA); pnlMCQ.Controls.Add(txtOptA);
            pnlMCQ.Controls.Add(lblOptB); pnlMCQ.Controls.Add(txtOptB);
            pnlMCQ.Controls.Add(lblOptC); pnlMCQ.Controls.Add(txtOptC);
            pnlMCQ.Controls.Add(lblOptD); pnlMCQ.Controls.Add(txtOptD);
            pnlMCQ.Controls.Add(lblAnswer); pnlMCQ.Controls.Add(cmbAnswer);

            // Buttons
            btnAdd = new Button { Text = "➕ Add Question", Font = new Font("Segoe UI", 10, FontStyle.Bold), BackColor = Color.FromArgb(56, 142, 60), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(20, 365), Size = new Size(160, 38) };
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            btnSave = new Button { Text = "💾 Save to File", Font = new Font("Segoe UI", 10, FontStyle.Bold), BackColor = Color.FromArgb(25, 118, 210), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(195, 365), Size = new Size(160, 38) };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += new System.EventHandler(this.btnSave_Click);

            btnLogout = new Button { Text = "🔒 Logout", Font = new Font("Segoe UI", 10), BackColor = Color.FromArgb(198, 40, 40), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(370, 365), Size = new Size(120, 38) };
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // Questions List (right side)
            Label lblListTitle = new Label { Text = "Questions Added:", Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(520, 85), AutoSize = true };
            lstQuestions = new ListBox { Font = new Font("Segoe UI", 9), Location = new Point(520, 108), Size = new Size(245, 295) };
            lblCount = new Label { Text = "Total Questions: 0", Font = new Font("Segoe UI", 9), Location = new Point(520, 410), AutoSize = true, ForeColor = Color.Gray };

            this.Controls.Add(pnlHeader);
            this.Controls.Add(lblQuestion); this.Controls.Add(txtQuestion);
            this.Controls.Add(lblType);     this.Controls.Add(cmbType);
            this.Controls.Add(pnlMCQ);
            this.Controls.Add(btnAdd); this.Controls.Add(btnSave); this.Controls.Add(btnLogout);
            this.Controls.Add(lblListTitle);
            this.Controls.Add(lstQuestions);
            this.Controls.Add(lblCount);
        }
    }
}
