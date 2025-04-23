using System.Collections.Generic;
using TO_DO_or_else.Domain;
using Microsoft.EntityFrameworkCore;

namespace TO_DO_or_else.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Rain;Database=ProductivityAppDb;Trusted_Connection=True;");
        }
    }
}
