namespace ExamProj.Class
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsTeacher { get; set; }
        public int TotalQuestions { get; set; }
        public int CorrectQuestions { get; set; }
        public int IncorrectQuestions { get; set; }
        public int NotAnsweredQuestions { get; set; }
    }
}