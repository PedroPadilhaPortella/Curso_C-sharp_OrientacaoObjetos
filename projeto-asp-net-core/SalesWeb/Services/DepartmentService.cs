using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWeb.Data;
using SalesWeb.Models;
using SalesWeb.Services.Exceptions;

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

        public async Task InsertAsync(Department department)
        {
            Database.Department.Add(department);
            await Database.SaveChangesAsync();
        }

        public async Task<Department> FindByIdAsync(int id)
        {
            return await Database.Department.FirstOrDefaultAsync(d => d.Id.Equals(id));
        }

        public async Task RemoveAsync(int id)
        {
            var department = await Database.Department.FindAsync(id);
            Database.Department.Remove(department);
            await Database.SaveChangesAsync();
        }

        public async Task UpdateAsync(Department department) 
        {
            bool hasAny = await Database.Department.AnyAsync(x => x.Id == department.Id);
            
            if(!hasAny)
                throw new NotFoundException("Id not found");
        
            try {
                Database.Update(department);
                await Database.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e) {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}