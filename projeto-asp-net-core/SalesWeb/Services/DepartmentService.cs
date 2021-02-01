using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWeb.Data;
using SalesWeb.Models;

namespace SalesWeb.Services
{
    public class DepartmentService
    {
        private readonly SalesWebContext Database;
        public DepartmentService(SalesWebContext database) {
            Database = database;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await Database.Department.OrderBy(d => d.Name).ToListAsync();
        }
    }
}