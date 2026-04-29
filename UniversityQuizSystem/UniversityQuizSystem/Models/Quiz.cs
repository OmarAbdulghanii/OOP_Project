using System;
using System.Collections.Generic;
using System.IO;

namespace UniversityQuizSystem.Models
{
    // Quiz class - manages an array of Question objects
    public class Quiz
    {
        // Array of Question objects (Demonstrates Array of Objects)
        private Question[] questions;
        private int count;
        private const int MAX_QUESTIONS = 50;

        public int Count => count;

        public Quiz()
        {
            questions = new Question[MAX_QUESTIONS];
            count = 0;
        }

        // Add a question to the array
        public void AddQuestion(Question q)
        {
            if (count < MAX_QUESTIONS)
            {
                questions[count] = q;
                count++;
            }
        }

        // Get a question by index
        public Question GetQuestion(int index)
        {
            if (index >= 0 && index < count)
                return questions[index];
            return null;
        }

        // Get all questions as a list (for display)
        public List<Question> GetAllQuestions()
        {
            List<Question> list = new List<Question>();
            for (int i = 0; i < count; i++)
                list.Add(questions[i]);
            return list;
        }

        // Clear all questions
        public void Clear()
        {
            questions = new Question[MAX_QUESTIONS];
            count = 0;
        }
    }

    // FileManager class - handles all file operations (Demonstrates File Handling)
    public static class FileManager
    {
        // Build a consistent file name from context
        public static string GetQuizFileName(string subject, StudyYear year, Semester semester, int section)
        {
            return $"{subject}_{year}_{semester}_Section{section}_questions.txt";
        }

        // Save questions to a file
        public static void SaveQuestions(Quiz quiz, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (Question q in quiz.GetAllQuestions())
            {
                lines.Add(q.ToFileString());
            }
            File.WriteAllLines(fileName, lines);
        }

        // Load questions from a file into a Quiz object
        public static Quiz LoadQuestions(string fileName)
        {
            Quiz quiz = new Quiz();
            if (!File.Exists(fileName)) return quiz;

            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    Question q = Question.FromFileString(line);
                    quiz.AddQuestion(q);
                }
            }
            return quiz;
        }

        // Append a student result to results.txt
        public static void SaveResult(string studentName, string subject, int score, int total)
        {
            string result = $"{studentName} - {subject} - Score: {score}/{total}";
            File.AppendAllText("results.txt", result + Environment.NewLine);
        }
    }
}
