using System.Windows.Forms;
using UniversityQuizSystem.Models;

namespace UniversityQuizSystem.Forms
{
    public partial class ResultForm : Form
    {
        public ResultForm(Student student)
        {
            InitializeComponent();

            lblName.Text    = $"Student:  {student.Name}";
            lblSubject.Text = $"Subject:  {student.Subject}";
            lblScore.Text   = $"Score:    {student.Score} / {student.TotalQuestions}";
            lblGrade.Text   = $"Grade:    {student.GetGrade()}";

            double pct = student.TotalQuestions > 0
                ? (double)student.Score / student.TotalQuestions * 100 : 0;
            lblPercent.Text = $"{pct:F0}%";

            // Colour feedback
            if (pct >= 70)
            {
                lblFeedback.Text      = "🎉 Congratulations! You passed!";
                lblFeedback.ForeColor = System.Drawing.Color.FromArgb(56, 142, 60);
            }
            else
            {
                lblFeedback.Text      = "📚 Keep studying — you can do it!";
                lblFeedback.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
