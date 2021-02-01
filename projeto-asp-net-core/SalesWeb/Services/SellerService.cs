using System.Collections.Generic;
using System.Linq;
using SalesWeb.Data;
using SalesWeb.Models;

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
            return Database.Seller.FirstOrDefault(s => s.Id.Equals(id));
        }

        public void Remove(int id) 
        {
            var seller = Database.Seller.Find(id);
            Database.Seller.Remove(seller);
            Database.SaveChanges();
        }
    }
}