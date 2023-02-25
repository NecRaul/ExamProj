using ExamProj.Class;
using System.Collections.Generic;

namespace ExamProj.Services.Interfaces
{
    public interface IAnswerServices
    {
        Answer GetAnswerByID(int id);
        void InsertAnswer(Answer answer);
        void UpdateAnswer(Answer answer);
        void DeleteAnswer(int id);
        IEnumerable<Answer> GetAllAnswers();
    }
}