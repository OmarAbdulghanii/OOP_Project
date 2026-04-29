namespace UniversityQuizSystem.Models
{
    // Base class: User (Demonstrates base class in Inheritance)
    public class User
    {
        // Properties
        public string Name { get; set; }
        public UserRole Role { get; set; }
        public StudyYear Year { get; set; }
        public Semester Semester { get; set; }
        public string Subject { get; set; }
        public ClassType ClassType { get; set; }
        public int SectionNumber { get; set; }

        // Constructor
        public User(string name, UserRole role)
        {
            Name = name;
            Role = role;
        }

        // Virtual method - can be overridden by subclasses
        public virtual string GetInfo()
        {
            return $"Name: {Name}, Role: {Role}";
        }
    }
}
