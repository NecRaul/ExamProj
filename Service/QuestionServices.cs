using ExamProj.Class;
using ExamProj.Repositories;
using ExamProj.Repositories.Interfaces;
using ExamProj.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ExamProj.Services
{
    internal class QuestionServices : IQuestionServices
    {
        private IRepository<Question> _repository;
        public QuestionServices(Repository<Question> repository)
        {
            _repository = repository;
        }
        public Question GetQuestionByID(int id)
        {
            return _repository.GetAll.Include(x => x.Answers).FirstOrDefault(x => x.ID == id);
        }
        public void InsertQuestion(Question question)
        {
            _repository.Insert(question);
        }
        public void UpdateQuestion(Question question)
        {
            _repository.Update(question);
        }
        public void DeleteQuestion(int id)
        {
            _repository.Delete(_repository.GetAll.FirstOrDefault(x => x.ID == id));
        }
        public IEnumerable<Question> GetAllQuestions()
        {
            return _repository.GetAll.Include(x => x.Answers);
        }
    }
}