using ExamProj.Class;
using System.Collections.Generic;

namespace ExamProj.Services.Interfaces
{
    public interface IQuestionServices
    {
        Question GetQuestionByID(int id);
        void InsertQuestion(Question question);
        void UpdateQuestion(Question question);
        void DeleteQuestion(int id);
        IEnumerable<Question> GetAllQuestions();
    }
}