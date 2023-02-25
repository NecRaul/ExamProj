namespace ExamProj.Class
{
    public class Answer : BaseEntity
    {
        public int QuestionID { get; set; }
        public string AnswerName { get; set; }
        public bool IsCorrect { get; set; }
    }
}