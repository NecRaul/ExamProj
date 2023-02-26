using ExamProj.Class;
using System.Collections.Generic;

namespace ExamProj.Services.Interfaces
{
    public interface IUserServices
    {
        User GetUserByID(int id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        IEnumerable<User> GetAllUsers();
    }
}