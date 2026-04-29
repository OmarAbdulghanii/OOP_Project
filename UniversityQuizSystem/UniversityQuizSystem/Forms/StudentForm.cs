using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UniversityQuizSystem.Models;

namespace UniversityQuizSystem.Forms
{
    public partial class StudentForm : Form
    {
        private Student student;
        private Quiz quiz;
        private List<Question> questions;
        private int currentIndex = 0;
        private string[] studentAnswers;

        public StudentForm(Student student)
        {
            InitializeComponent();
            this.student = student;
            lblInfo.Text = $"Student: {student.Name}  |  Subject: {student.Subject}  |  Section {student.SectionNumber}";

            string fileName = FileManager.GetQuizFileName(student.Subject, student.Year, student.Semester, student.SectionNumber);
            quiz = FileManager.LoadQuestions(fileName);
            questions = quiz.GetAllQuestions();

            if (questions.Count == 0)
            {
                MessageBox.Show("No questions available for this quiz yet.\nPlease ask your lecturer to add questions.", "No Questions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Load += (s, e) => { btnSubmit.Enabled = false; btnNext.Enabled = false; };
                return;
            }

            studentAnswers = new string[questions.Count];
            LoadQuestion(0);
        }

        // Load a specific question by index
        private void LoadQuestion(int index)
        {
            Question q = questions[index];
            lblProgress.Text = $"Question {index + 1} of {questions.Count}";
            lblQuestion.Text = $"Q{index + 1}. {q.QuestionText}";
            pnlMCQ.Visible = false;
            pnlEssay.Visible = false;
            lblAnswerType.Text = "";

            if (q.Type == QuestionType.MultipleChoice)
            {
                pnlMCQ.Visible = true;
                rbA.Text = q.Options.Length > 0 ? q.Options[0] : "A";
                rbB.Text = q.Options.Length > 1 ? q.Options[1] : "B";
                rbC.Text = q.Options.Length > 2 ? q.Options[2] : "C";
                rbD.Text = q.Options.Length > 3 ? q.Options[3] : "D";

                // Restore previous answer if navigating back
                rbA.Checked = (studentAnswers[index] == "A");
                rbB.Checked = (studentAnswers[index] == "B");
                rbC.Checked = (studentAnswers[index] == "C");
                rbD.Checked = (studentAnswers[index] == "D");
            }
            else
            {
                pnlEssay.Visible = true;
                txtEssay.Text = studentAnswers[index] ?? "";
                lblAnswerType.Text = "(Essay question — write your answer below)";
            }

            btnPrev.Enabled = (index > 0);
            btnNext.Enabled = (index < questions.Count - 1);
            btnSubmit.Enabled = (index == questions.Count - 1);
        }

        // Save the current answer before navigating
        private void SaveCurrentAnswer()
        {
            Question q = questions[currentIndex];
            if (q.Type == QuestionType.MultipleChoice)
            {
                if (rbA.Checked) studentAnswers[currentIndex] = "A";
                else if (rbB.Checked) studentAnswers[currentIndex] = "B";
                else if (rbC.Checked) studentAnswers[currentIndex] = "C";
                else if (rbD.Checked) studentAnswers[currentIndex] = "D";
                else studentAnswers[currentIndex] = "";
            }
            else
            {
                studentAnswers[currentIndex] = txtEssay.Text.Trim();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            currentIndex++;
            LoadQuestion(currentIndex);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();
            currentIndex--;
            LoadQuestion(currentIndex);
        }

        // Submit quiz and calculate score
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();

            int score = 0;
            int mcqTotal = 0;

            // Calculate score (only MCQ questions are auto-graded)
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Type == QuestionType.MultipleChoice)
                {
                    mcqTotal++;
                    if (questions[i].CheckAnswer(studentAnswers[i]))
                        score++;
                }
            }

            student.Score = score;
            student.TotalQuestions = mcqTotal > 0 ? mcqTotal : questions.Count;

            // Save result to file (File Handling)
            FileManager.SaveResult(student.Name, student.Subject, score, student.TotalQuestions);

            // Show result form
            ResultForm result = new ResultForm(student);
            result.ShowDialog();
            this.Close();
        }
    }
}
