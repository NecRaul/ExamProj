using ExamProj.Class;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ExamProj.Context
{
    public class ExamDbContext : DbContext
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConStr"].ConnectionString.ToString();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}