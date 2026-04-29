using System;
using System.Windows.Forms;
using UniversityQuizSystem.Forms;
using UniversityQuizSystem.Models;

namespace UniversityQuizSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                SelectionForm selectionForm = new SelectionForm(loginForm.LoggedInUser);
                Application.Run(selectionForm);
            }
        }
    }
}
