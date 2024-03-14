using Microsoft.EntityFrameworkCore;
using ToDoList.Models;
namespace ToDoList.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet <ToDoTask> ToDotasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoTask>().HasData(

                new ToDoTask { Id = 1, Title = "Do HomeWork", Description = "Maths Homework at 18:00" },
                new ToDoTask { Id = 2, Title = "Take Out Trash", Description = "By 16:00 I need To Have Taken Out Trash" },
                new ToDoTask { Id = 3, Title = "Meet Somoone", Description = "My friend is coming over" }

                );


        }

        }
}
