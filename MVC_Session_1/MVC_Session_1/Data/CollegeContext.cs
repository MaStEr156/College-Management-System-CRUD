using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MVC_Session_1.Models;

namespace MVC_Session_1.Data
{
    public class CollegeContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }

        public CollegeContext(DbContextOptions options) : base(options)
        {

        }
        public CollegeContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=MASTER;Database=College_MVC;Integrated Security=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
