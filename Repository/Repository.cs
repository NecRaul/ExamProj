using ExamProj.Class;
using ExamProj.Context;
using ExamProj.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows;

namespace ExamProj.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ExamDbContext _context;
        private DbSet<T> _entities;
        private DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<T>();
                return _entities;
            }
        }
        public Repository(ExamDbContext context)
        {
            this._context = context;
        }
        public T Get(T entity)
        {
            return Entities.Find(entity);
        }
        public void Insert(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException();
                Entities.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception dbEx)
            {
                MessageBox.Show(dbEx.Message);
                return;
            }
        }
        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException();
                Entities.Update(entity);
                _context.SaveChanges();
            }
            catch (Exception dbEx)
            {
                MessageBox.Show(dbEx.Message);
                return;
            }
        }
        public void Delete(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException();
                Entities.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception dbEx)
            {
                MessageBox.Show(dbEx.Message);
                return;
            }
        }
        public virtual IQueryable<T> GetAll
        {
            get
            {
                return Entities;
            }
        }
    }
}