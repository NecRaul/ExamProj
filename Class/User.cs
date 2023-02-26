namespace ExamProj.Class
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsTeacher { get; set; } = false;
    }
}