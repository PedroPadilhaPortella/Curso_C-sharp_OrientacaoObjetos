using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SalesWeb.Data;
using SalesWeb.Models;
using SalesWeb.Services.Exceptions;

namespace SalesWeb.Services
{
    public class SellerService
    {
        private readonly SalesWebContext Database;
        public SellerService(SalesWebContext database) {
            Database = database;
        }

        public List<Seller> FindAll()
        {
            return Database.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            Database.Seller.Add(seller);
            Database.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return Database.Seller.Include(s => s.Department).FirstOrDefault(s => s.Id.Equals(id));
        }

        public void Remove(int id)
        {
            var seller = Database.Seller.Find(id);
            Database.Seller.Remove(seller);
            Database.SaveChanges();
        }

        public void Update(Seller seller) 
        {
            if(!Database.Seller.Any(x => x.Id == seller.Id))
                throw new NotFoundException("Id not found");
        
            try {
                Database.Update(seller);
                Database.SaveChanges();
            } 
            catch (DbUpdateConcurrencyException e) {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}