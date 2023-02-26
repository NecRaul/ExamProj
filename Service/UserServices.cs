using ExamProj.Class;
using ExamProj.Repositories;
using ExamProj.Repositories.Interfaces;
using ExamProj.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ExamProj.Services
{
    internal class UserServices : IUserServices
    {
        private IRepository<User> _repository;
        public UserServices(Repository<User> repository)
        {
            _repository = repository;
        }
        public User GetUserByID(int id)
        {
            return _repository.GetAll.AsNoTracking().FirstOrDefault(x => x.ID == id);
        }
        public void InsertUser(User user)
        {
           _repository.Insert(user);    
        }
        public void UpdateUser(User user)
        {
            _repository.Update(user);
        }
        public void DeleteUser(int id)
        {
            _repository.Delete(_repository.GetAll.FirstOrDefault(x => x.ID == id));
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _repository.GetAll.AsNoTracking();
        }
    }
}