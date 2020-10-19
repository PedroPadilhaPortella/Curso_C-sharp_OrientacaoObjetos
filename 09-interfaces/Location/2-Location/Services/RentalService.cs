using Location.Entities;
using System;

namespace Location.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _TaxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService; //inversao de controle por meio de injecao de dependencia
        }
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start); //Diferença de tempo
            double basicPayment = 0.0;
            if(duration.TotalHours <= 12){
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);//Converte para horas e arredonda pra cima
            }else{
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);//Converte para dias e arredonda para baixo
            }
            double tax = _TaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}