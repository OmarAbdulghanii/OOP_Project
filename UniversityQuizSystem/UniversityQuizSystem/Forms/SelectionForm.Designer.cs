using System.Drawing;
using System.Windows.Forms;

namespace UniversityQuizSystem.Forms
{
    partial class SelectionForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblWelcome;
        private Label lblYear;
        private ComboBox cmbYear;
        private Label lblSemester;
        private ComboBox cmbSemester;
        private Label lblSubject;
        private ComboBox cmbSubject;
        private Label lblClassType;
        private RadioButton rbLecture;
        private RadioButton rbSection;
        private Label lblSection;
        private NumericUpDown nudSection;
        private Button btnContinue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Text = "University Quiz System - Select Course";
            this.Size = new Size(460, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

            // Header
            pnlHeader = new Panel();
            pnlHeader.BackColor = Color.FromArgb(25, 118, 210);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;

            lblTitle = new Label();
            lblTitle.Text = "🎓 University Quiz System";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(80, 10);
            pnlHeader.Controls.Add(lblTitle);

            lblWelcome = new Label();
            lblWelcome.ForeColor = Color.LightCyan;
            lblWelcome.Font = new Font("Segoe UI", 9);
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(80, 40);
            pnlHeader.Controls.Add(lblWelcome);

            // Study Year
            lblYear = new Label { Text = "Study Year:", Font = new Font("Segoe UI", 10), Location = new Point(40, 90), AutoSize = true };
            cmbYear = new ComboBox { Font = new Font("Segoe UI", 10), Location = new Point(170, 87), Size = new Size(220, 28), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbYear.Items.AddRange(new string[] { "First Year", "Second Year", "Third Year", "Fourth Year" });
            cmbYear.SelectedIndex = 0;

            // Semester
            lblSemester = new Label { Text = "Semester:", Font = new Font("Segoe UI", 10), Location = new Point(40, 135), AutoSize = true };
            cmbSemester = new ComboBox { Font = new Font("Segoe UI", 10), Location = new Point(170, 132), Size = new Size(220, 28), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbSemester.Items.AddRange(new string[] { "First Semester", "Second Semester" });
            cmbSemester.SelectedIndex = 0;

            // Subject
            lblSubject = new Label { Text = "Subject:", Font = new Font("Segoe UI", 10), Location = new Point(40, 180), AutoSize = true };
            cmbSubject = new ComboBox { Font = new Font("Segoe UI", 10), Location = new Point(170, 177), Size = new Size(220, 28), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbSubject.Items.AddRange(new string[] { "OOP", "Programming", "Math", "Database", "Networking" });
            cmbSubject.SelectedIndex = 0;

            // Class Type
            lblClassType = new Label { Text = "Class Type:", Font = new Font("Segoe UI", 10), Location = new Point(40, 225), AutoSize = true };
            rbLecture = new RadioButton { Text = "Lecture", Font = new Font("Segoe UI", 10), Location = new Point(170, 223), AutoSize = true, Checked = true };
            rbSection = new RadioButton { Text = "Section", Font = new Font("Segoe UI", 10), Location = new Point(270, 223), AutoSize = true };
            rbLecture.CheckedChanged += new System.EventHandler(this.rbLecture_CheckedChanged);

            // Section Number
            lblSection = new Label { Text = "Section No.:", Font = new Font("Segoe UI", 10), Location = new Point(40, 270), AutoSize = true };
            nudSection = new NumericUpDown { Font = new Font("Segoe UI", 10), Location = new Point(170, 267), Size = new Size(80, 28), Minimum = 1, Maximum = 10, Value = 1, Enabled = false };

            // Continue Button
            btnContinue = new Button
            {
                Text = "Continue →",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                BackColor = Color.FromArgb(25, 118, 210),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(350, 44),
                Location = new Point(50, 340)
            };
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.Click += new System.EventHandler(this.btnContinue_Click);

            this.Controls.Add(pnlHeader);
            this.Controls.Add(lblYear);    this.Controls.Add(cmbYear);
            this.Controls.Add(lblSemester); this.Controls.Add(cmbSemester);
            this.Controls.Add(lblSubject);  this.Controls.Add(cmbSubject);
            this.Controls.Add(lblClassType); this.Controls.Add(rbLecture); this.Controls.Add(rbSection);
            this.Controls.Add(lblSection);  this.Controls.Add(nudSection);
            this.Controls.Add(btnContinue);
        }
    }
}
