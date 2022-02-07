using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Cqrs.Data
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext>contextOptions):base(contextOptions)
        {

        }

        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new List<Student>
            {
                new Student{ Id = 1, Name ="Yavuz",SurName = "Kahraman" ,Age = 29},
                new Student{ Id = 2, Name ="Mehmet",SurName = "Kahraman" ,Age = 25},
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
