namespace UniversityQuizSystem.Models
{
   
    public class User
    {
        public string Name { get; set; }
        public UserRole Role { get; set; }
        public StudyYear Year { get; set; }
        public Semester Semester { get; set; }
        public string Subject { get; set; }
        public ClassType ClassType { get; set; }
        public int SectionNumber { get; set; }

        public User(string name, UserRole role)
        {
            Name = name;
            Role = role;
        }


        public virtual string GetInfo()
        {
            return $"Name: {Name}, Role: {Role}";
        }
    }
}
