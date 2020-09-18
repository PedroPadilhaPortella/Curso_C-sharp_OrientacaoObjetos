using System;

namespace iso8601
{
    class Program
    {
        static void Main(string[] args)
        {
            // Padrão ISO 8601 -> yyyy-MM-ddTHH:mm:ssZ(Z de utc)

            DateTime data1 = DateTime.Parse("2000-08-15 13:10:15");
            DateTime data2 = DateTime.Parse("2000-08-15T13:10:15Z"); 
            //Ira formatar essa data para o padrão Local, subtraindo 3 horas

            Console.WriteLine(data1);
            Console.WriteLine(data1.Kind);//data local, que pode ser convertida em utc
            Console.WriteLine($"LocalTime: {data1.ToLocalTime()}");
            Console.WriteLine($"UniversalTime {data1.ToUniversalTime()}");

            Console.WriteLine(data2);
            Console.WriteLine(data2.Kind);//data utc, que pode ser convertida em local
            Console.WriteLine($"LocalTime: {data2.ToLocalTime()}");
            Console.WriteLine($"UniversalTime {data2.ToUniversalTime()}");

            Console.WriteLine(data2.ToUniversalTime().ToString("yyyy-MM-ddYHH:mm:ssZ"));
            //Converte pra o formato universal e depois para string, que pode ser usada em apis, json, etc;
        }
    }
}
