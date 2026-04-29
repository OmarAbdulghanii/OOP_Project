namespace UniversityQuizSystem.Models
{
    // Lecturer class: inherits from User (Demonstrates Inheritance)
    public class Lecturer : User
    {
        public string Department { get; set; }

        // Constructor calls base class constructor
        public Lecturer(string name) : base(name, UserRole.Lecturer)
        {
            Department = "General";
        }

        // Override base method
        public override string GetInfo()
        {
            return $"Lecturer: {Name} | Department: {Department}";
        }
    }
}
