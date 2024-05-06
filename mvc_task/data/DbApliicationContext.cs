using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using mvc_task.Models;

namespace mvc_task.context
{
    public class DbApliicationContext :DbContext 
    { 
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=employee;Trusted_Connection=True;");
        }

    }
}
