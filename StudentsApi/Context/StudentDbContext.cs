using Microsoft.EntityFrameworkCore;
using StudentsApi.Models;

namespace StudentsApi.Context
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) 
        {
        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Gustavo Passos",
                    Email = "gustavofsp@hotmail.com",
                    Idade = 32
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Natacha Passos",
                    Email = "natachafsp@hotmail.com",
                    Idade = 35
                }
                );



        }
    }
}
