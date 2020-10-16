using System.Globalization;
using System;

namespace Location.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment{ get { return BasicPayment + Tax;} }
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }


        public override string ToString()
        {
            return "Basix Payment:" + BasicPayment.ToString("F2", CultureInfo.InvariantCulture) + 
            "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture) +
            "\nTotal Payment: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}