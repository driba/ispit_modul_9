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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { 
                    StudentID = 1,
                    StudentName = "Ivan Ivic",
                    DateOfBirth = new DateTime(1988, 1, 1),
                    Height = 201.5m,
                    Weight = 100
                },
                new Student
                {
                    StudentID = 2,
                    StudentName = "Hrvoje Horvat",
                    DateOfBirth = new DateTime(1950, 11, 11),
                    Height = 181.5m,
                    Weight = 83
                }
            );

            modelBuilder.Entity<Grade>().HasData(
                new Grade {
                    GradeId = 1,
                    GradeName = "Dovoljan",
                    Section = "Modul 1",
                    StudentId = 1                    
                },
                new Grade
                {
                    GradeId = 2,
                    GradeName = "Nedovoljan",
                    Section = "Modul 1",
                    StudentId = 2
                },
                new Grade
                {
                    GradeId = 3,
                    GradeName = "Odličan",
                    Section = "Modul 2",
                    StudentId = 1
                },
                new Grade
                {
                    GradeId = 4,
                    GradeName = "Odličan",
                    Section = "Modul 2",
                    StudentId = 2
                },
                new Grade
                {
                    GradeId = 5,
                    GradeName = "Odličan",
                    Section = "Modul 3",
                    StudentId = 1
                },
                new Grade
                {
                    GradeId = 6,
                    GradeName = "Odličan",
                    Section = "Modul 3",
                    StudentId = 2
                },
                new Grade
                {
                    GradeId = 7,
                    GradeName = "Odličan",
                    Section = "Modul 1",
                    StudentId = 2
                }
            );


        }
    }
}
