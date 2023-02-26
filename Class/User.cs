namespace ExamProj.Class
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsTeacher { get; set; } = false;
        public int TotalQuestions { get; set; }
        public int CorrectAnswers { get; set; }
        public int IncorrectAnswers { get; set; }
        public int NotAnswered { get; set; }
    }
}