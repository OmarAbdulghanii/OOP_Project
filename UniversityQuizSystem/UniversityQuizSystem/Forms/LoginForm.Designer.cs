using System.Drawing;
using System.Windows.Forms;

namespace UniversityQuizSystem.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblRole;
        private RadioButton rbStudent;
        private RadioButton rbLecturer;
        private Button btnLogin;
        private Panel pnlHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblRole = new Label();
            rbStudent = new RadioButton();
            rbLecturer = new RadioButton();
            btnLogin = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(25, 118, 210);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(763, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(193, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(356, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🎓 University Quiz System";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(219, 115);
            lblName.Name = "lblName";
            lblName.Size = new Size(91, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name:";
            lblName.Click += lblName_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(219, 159);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 30);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRole.Location = new Point(219, 230);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(97, 23);
            lblRole.TabIndex = 3;
            lblRole.Text = "Select Role:";
            lblRole.Click += lblRole_Click;
            // 
            // rbStudent
            // 
            rbStudent.AutoSize = true;
            rbStudent.Checked = true;
            rbStudent.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbStudent.Location = new Point(219, 267);
            rbStudent.Name = "rbStudent";
            rbStudent.Size = new Size(90, 27);
            rbStudent.TabIndex = 4;
            rbStudent.TabStop = true;
            rbStudent.Text = "Student";
            rbStudent.CheckedChanged += rbStudent_CheckedChanged;
            // 
            // rbLecturer
            // 
            rbLecturer.AutoSize = true;
            rbLecturer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbLecturer.Location = new Point(426, 267);
            rbLecturer.Name = "rbLecturer";
            rbLecturer.Size = new Size(93, 27);
            rbLecturer.TabIndex = 5;
            rbLecturer.Text = "Lecturer";
            rbLecturer.CheckedChanged += rbLecturer_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(25, 118, 210);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(219, 333);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 42);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(763, 438);
            Controls.Add(pnlHeader);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblRole);
            Controls.Add(rbStudent);
            Controls.Add(rbLecturer);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "University Quiz System - Login";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
