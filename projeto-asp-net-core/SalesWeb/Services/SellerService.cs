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
    }
}