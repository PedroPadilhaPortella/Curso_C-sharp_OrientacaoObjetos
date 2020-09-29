using System;
using System.Globalization;


namespace Produtos.Entities
{
    class UsedProduct: Product
    {
        public DateTime ManufacturedDate { get; set; }
        public UsedProduct(){}
        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }
        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)},"
            + $" (Manufactured date: {ManufacturedDate})";
        }
    }
}