using ExamProj.Class;
using System.Linq;

namespace ExamProj.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(T entity);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll { get; }
    }
}