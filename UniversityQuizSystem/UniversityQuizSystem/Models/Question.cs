namespace UniversityQuizSystem.Models
{
    // Question class (Demonstrates Classes and Array of Objects)
    public class Question
    {
        public string QuestionText { get; set; }
        public QuestionType Type { get; set; }

        // For Multiple Choice: options A, B, C, D
        public string[] Options { get; set; }

        // Correct answer (for MCQ: "A", "B", "C", or "D")
        public string CorrectAnswer { get; set; }

        // Constructor for Essay question
        public Question(string questionText)
        {
            QuestionText = questionText;
            Type = QuestionType.Essay;
            Options = new string[0];
            CorrectAnswer = "";
        }

        // Constructor for Multiple Choice question
        public Question(string questionText, string[] options, string correctAnswer)
        {
            QuestionText = questionText;
            Type = QuestionType.MultipleChoice;
            Options = options;
            CorrectAnswer = correctAnswer.ToUpper();
        }

        // Check if a student's answer is correct (MCQ only)
        public bool CheckAnswer(string studentAnswer)
        {
            if (Type == QuestionType.Essay) return false;
            return studentAnswer.Trim().ToUpper() == CorrectAnswer;
        }

        // Convert question to a saveable string format
        public string ToFileString()
        {
            if (Type == QuestionType.Essay)
            {
                return $"ESSAY|{QuestionText}";
            }
            else
            {
                string opts = string.Join("~", Options);
                return $"MCQ|{QuestionText}|{opts}|{CorrectAnswer}";
            }
        }

        // Create a Question object from a saved file line
        public static Question FromFileString(string line)
        {
            string[] parts = line.Split('|');
            if (parts[0] == "ESSAY")
            {
                return new Question(parts[1]);
            }
            else // MCQ
            {
                string[] options = parts[2].Split('~');
                return new Question(parts[1], options, parts[3]);
            }
        }
    }
}
