using System.Collections.Generic;

namespace ExamProj.Class
{
    public class Question : BaseEntity
    {
        public string Difficulty { get; set; }
        public string QuestionName { get; set; }
        private string _correctAnswer;
        public string CorrectAnswer
        {
            get
            {
                if (Answers == null)
                {
                    return "";
                    
                }
                foreach (var answer in Answers)
                {
                    if (answer.IsCorrect)
                    {
                        _correctAnswer = answer.AnswerName;
                    }
                }
                return _correctAnswer;
            }
        }
        public bool IsAnswered = false;
        public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}