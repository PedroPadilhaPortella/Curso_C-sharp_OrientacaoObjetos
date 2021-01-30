using Microsoft.EntityFrameworkCore;
using SalesWeb.Models;

namespace SalesWeb.Data
{
    public class SalesWebContext : DbContext
    {
        public DbSet<Department> Department { get; set; }

        public SalesWebContext (DbContextOptions<SalesWebContext> options) : base(options) {}
    }
}