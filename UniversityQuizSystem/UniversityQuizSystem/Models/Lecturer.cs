namespace UniversityQuizSystem.Models
{
    
    public class Lecturer : User
    {
        public string Department { get; set; }

  
        public Lecturer(string name) : base(name, UserRole.Lecturer)
        {
            Department = "General";
        }

        
        public override string GetInfo()
        {
            return $"Lecturer: {Name} | Department: {Department}";
        }
    }
}
