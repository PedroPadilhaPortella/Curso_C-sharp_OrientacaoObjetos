using System.Collections.Generic;
using System.Linq;
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

        public List<Department> FindAll()
        {
            return Database.Department.OrderBy(d => d.Name).ToList();
        }
    }
}