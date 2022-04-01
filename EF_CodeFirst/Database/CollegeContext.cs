using Microsoft.EntityFrameworkCore;
using EF_CodeFirst.Models;

namespace EF_CodeFirst.Database
{
    public class CollegeContext : DbContext
    {
        public CollegeContext(DbContextOptions<CollegeContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        
    }
}
