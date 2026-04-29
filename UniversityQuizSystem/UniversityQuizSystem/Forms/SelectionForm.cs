using System;
using System.Windows.Forms;
using UniversityQuizSystem.Models;

namespace UniversityQuizSystem.Forms
{
    public partial class SelectionForm : Form
    {
        private User currentUser;

        public SelectionForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblWelcome.Text = $"Welcome, {user.Name}!  ({user.Role})";
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

            currentUser.Year   = (StudyYear)cmbYear.SelectedIndex;
            currentUser.Semester = (Semester)cmbSemester.SelectedIndex;
            currentUser.Subject  = cmbSubject.SelectedItem.ToString();
            currentUser.ClassType = rbLecture.Checked ? ClassType.Lecture : ClassType.Section;
            currentUser.SectionNumber = (int)nudSection.Value;


            if (currentUser.Role == UserRole.Lecturer)
            {
                LecturerForm form = new LecturerForm(currentUser);
                form.Show();
            }
            else
            {
                StudentForm form = new StudentForm(currentUser as Student);
                form.Show();
            }

            this.Hide();
        }

        private void rbLecture_CheckedChanged(object sender, EventArgs e)
        {
            nudSection.Enabled = rbSection.Checked;
        }
    }
}
