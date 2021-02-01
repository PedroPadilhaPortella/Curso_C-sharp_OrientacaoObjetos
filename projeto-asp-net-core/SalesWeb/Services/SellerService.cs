using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWeb.Data;
using SalesWeb.Models;
using SalesWeb.Services.Exceptions;

namespace SalesWeb.Services
{
    public class SellerService
    {
        private readonly SalesWebContext Database;
        public SellerService(SalesWebContext database)
        {
            Database = database;
        }


        public async Task<List<Seller>> FindAllAsync()
        {
            return await Database.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller seller)
        {
            Database.Seller.Add(seller);
            await Database.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await Database.Seller.Include(s => s.Department).FirstOrDefaultAsync(s => s.Id.Equals(id));
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var seller = await Database.Seller.FindAsync(id);
                Database.Seller.Remove(seller);
                await Database.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw new IntegrityException("It's not possible delete a Seller who has Sales Records related");
            }
        }

        public async Task UpdateAsync(Seller seller)
        {
            bool hasAny = await Database.Seller.AnyAsync(x => x.Id == seller.Id);

            if (!hasAny)
                throw new NotFoundException("Id not found");

            try
            {
                Database.Update(seller);
                await Database.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}