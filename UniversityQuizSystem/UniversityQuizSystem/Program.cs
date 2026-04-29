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

            // Show Login Form first
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // After login, show the selection form
                SelectionForm selectionForm = new SelectionForm(loginForm.LoggedInUser);
                Application.Run(selectionForm);
            }
        }
    }
}
