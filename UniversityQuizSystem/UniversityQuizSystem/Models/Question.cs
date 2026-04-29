namespace UniversityQuizSystem.Models
{

    public class Question
    {
        public string QuestionText { get; set; }
        public QuestionType Type { get; set; }

     
        public string[] Options { get; set; }

        public string CorrectAnswer { get; set; }


        public Question(string questionText)
        {
            QuestionText = questionText;
            Type = QuestionType.Essay;
            Options = new string[0];
            CorrectAnswer = "";
        }


        public Question(string questionText, string[] options, string correctAnswer)
        {
            QuestionText = questionText;
            Type = QuestionType.MultipleChoice;
            Options = options;
            CorrectAnswer = correctAnswer.ToUpper();
        }


        public bool CheckAnswer(string studentAnswer)
        {
            if (Type == QuestionType.Essay) return false;
            return studentAnswer.Trim().ToUpper() == CorrectAnswer;
        }

    
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


        public static Question FromFileString(string line)
        {
            string[] parts = line.Split('|');
            if (parts[0] == "ESSAY")
            {
                return new Question(parts[1]);
            }
            else 
            {
                string[] options = parts[2].Split('~');
                return new Question(parts[1], options, parts[3]);
            }
        }
    }
}
