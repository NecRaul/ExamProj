using ExamProj.Class;
using ExamProj.Repositories;
using ExamProj.Repositories.Interfaces;
using ExamProj.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ExamProj.Services
{
    internal class AnswerServices : IAnswerServices
    {
        private IRepository<Answer> _repository;
        public AnswerServices(Repository<Answer> repository)
        {
            _repository = repository;
        }
        public Answer GetAnswerByID(int id)
        {
            return _repository.GetAll.FirstOrDefault(x => x.ID == id);
        }
        public void InsertAnswer(Answer answer)
        {
           _repository.Insert(answer);    
        }
        public void UpdateAnswer(Answer answer)
        {
            _repository.Update(answer);
        }
        public void DeleteAnswer(int id)
        {
            _repository.Delete(_repository.GetAll.FirstOrDefault(x => x.ID == id));
        }
        public IEnumerable<Answer> GetAllAnswers()
        {
            return _repository.GetAll;
        }
    }
}