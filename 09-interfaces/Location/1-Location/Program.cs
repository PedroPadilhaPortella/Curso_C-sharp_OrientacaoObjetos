using System;
using System.Globalization;
using Location.Entities;
using Location.Services;

namespace Location
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rental Data");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("PickUp (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            System.Console.WriteLine("INVOICE:");
            System.Console.WriteLine(carRental.Invoice);
        }
    }
}
