using System;
using Hotel.Entities;
using Hotel.Entities.Exceptions;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reserva = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reserva);

                Console.WriteLine("\nEnter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reserva.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reserva);
            }
            catch (DomainException err)
            {
                Console.WriteLine("Error in Reservation: " + err.Message);
            }
            catch (FormatException err)
            {
                Console.WriteLine("Format Error: " + err.Message);
            }
            catch (Exception err)
            {
                Console.WriteLine("General Error: " + err.Message);
            }
        }
    }
}