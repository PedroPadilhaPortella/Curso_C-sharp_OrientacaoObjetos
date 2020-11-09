using Microsoft.EntityFrameworkCore;
using Sales.Models;

namespace Sales.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }


        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options){}

    }
}