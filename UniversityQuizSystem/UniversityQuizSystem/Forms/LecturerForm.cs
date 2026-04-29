using System;
using System.Windows.Forms;
using UniversityQuizSystem.Models;

namespace UniversityQuizSystem.Forms
{
    public partial class LecturerForm : Form
    {
        private User currentUser;
        private Quiz quiz;
        private string fileName;

        public LecturerForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            fileName = FileManager.GetQuizFileName(user.Subject, user.Year, user.Semester, user.SectionNumber);

            quiz = FileManager.LoadQuestions(fileName);
            RefreshQuestionList();

            lblInfo.Text = $"Lecturer: {user.Name}  |  Subject: {user.Subject}  |  Section {user.SectionNumber}";
        }

    
        private void RefreshQuestionList()
        {
            lstQuestions.Items.Clear();
            foreach (Question q in quiz.GetAllQuestions())
            {
                string prefix = q.Type == QuestionType.MultipleChoice ? "[MCQ] " : "[Essay] ";
                lstQuestions.Items.Add(prefix + q.QuestionText);
            }
            lblCount.Text = $"Total Questions: {quiz.Count}";
        }

       
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlMCQ.Visible = (cmbType.SelectedIndex == 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string questionText = txtQuestion.Text.Trim();
            if (string.IsNullOrEmpty(questionText))
            {
                MessageBox.Show("Please enter a question.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Question newQuestion;

            if (cmbType.SelectedIndex == 0) 
            {
                string optA = txtOptA.Text.Trim();
                string optB = txtOptB.Text.Trim();
                string optC = txtOptC.Text.Trim();
                string optD = txtOptD.Text.Trim();
                string answer = cmbAnswer.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(optA) || string.IsNullOrEmpty(optB) ||
                    string.IsNullOrEmpty(optC) || string.IsNullOrEmpty(optD) || string.IsNullOrEmpty(answer))
                {
                    MessageBox.Show("Please fill all options and select the correct answer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string[] options = new string[] {
                    "A. " + optA,
                    "B. " + optB,
                    "C. " + optC,
                    "D. " + optD
                };
                newQuestion = new Question(questionText, options, answer);
            }
            else 
            {
                newQuestion = new Question(questionText);
            }

            quiz.AddQuestion(newQuestion);
            RefreshQuestionList();
            ClearInputs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileManager.SaveQuestions(quiz, fileName);
            MessageBox.Show($"Questions saved to:\n{fileName}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearInputs()
        {
            txtQuestion.Clear();
            txtOptA.Clear();
            txtOptB.Clear();
            txtOptC.Clear();
            txtOptD.Clear();
            cmbAnswer.SelectedIndex = -1;
        }

       
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            if (login.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SelectionForm sel = new SelectionForm(login.LoggedInUser);
                sel.Show();
            }
        }
    }
}
