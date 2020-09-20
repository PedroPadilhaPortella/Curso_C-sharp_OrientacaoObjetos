using System;
using OrderEnum.Entities;
using OrderEnum.Entities.Enums;

namespace OrderEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando uma classe que tem um atributo do Tipo OrderStatus, que é um Enum
            Order order = new Order
            {
                Id = 4930,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            System.Console.WriteLine(order);

            string texto = OrderStatus.PendingPayment.ToString(); //Converter Enum para String
            System.Console.WriteLine(texto);

            OrderStatus osx = Enum.Parse<OrderStatus>("Delivered"); //Converte String para Enum
            System.Console.WriteLine(osx);

            //Outras formas de converter String para Enum do tipo OrderStatus

            // OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            //OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            //OrderStatus os;
            //Enum.TryParse("Delivered", out os);
        }
    }
}
