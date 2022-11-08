using Microsoft.EntityFrameworkCore;
using UniversityOB.API.Models.DataModels;

namespace UniversityOB.API.DataAccess
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {

        }

        // DbSets

        public DbSet<User>? Users {get; set; }   

        public DbSet<Course>? Courses {get; set; }

        public DbSet<Category>? Categories  { get; set; }

        public DbSet<Student>? Students {get; set; }

        public DbSet<Chapter>? Chapters {get; set; }
    }
}
