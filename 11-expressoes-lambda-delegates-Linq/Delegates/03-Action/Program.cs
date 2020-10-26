using System;
using System.Collections.Generic;
using Action.Entities;

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

    //01- Usando Action para atribuir o delegate
            // Action<Product> action1 = UpdatePrice;
            // list.ForEach(action1);

    //02- Chamando o delegate diretamente no ForEach
            // list.ForEach(UpdatePrice);

    //03- Usando Action com expressão lambda
            // Action<Product> action2 = p => {
            //     p.Price += p.Price * 0.1;
            // };
            // list.ForEach(action2);

    //04- Usando apenas expressão lambda
            list.ForEach(p => {
                p.Price += p.Price * 0.1;
            });

            foreach (Product produto in list){
                Console.WriteLine(produto);
            }
        }

        public static void UpdatePrice(Product p){
            p.Price += p.Price * 0.1;
        }
    }
}
