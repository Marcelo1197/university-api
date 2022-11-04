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
    }
}
