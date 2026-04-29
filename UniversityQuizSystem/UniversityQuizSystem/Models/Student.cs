namespace UniversityQuizSystem.Models
{

    public class Student : User
    {
        public int Score { get; set; }
        public int TotalQuestions { get; set; }


        public Student(string name) : base(name, UserRole.Student)
        {
            Score = 0;
            TotalQuestions = 0;
        }


        public override string GetInfo()
        {
            return $"Student: {Name} | Score: {Score}/{TotalQuestions}";
        }

      
        public string GetGrade()
        {
            if (TotalQuestions == 0) return "N/A";

            double percentage = (double)Score / TotalQuestions * 100;

            if (percentage >= 90) return "A";
            else if (percentage >= 80) return "B";
            else if (percentage >= 70) return "C";
            else if (percentage >= 60) return "D";
            else return "F";
        }
    }
}
