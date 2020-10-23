using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "pedro1212";
            cookies["name"] = "pedro portella";
            cookies.Add("email", "pedro@gmail.com");
            cookies["phone"] = "55999-9999";
            cookies["phone"] = "55988-9955";//sobrescricao do valor
            cookies.Add("age", "19");

            Console.WriteLine(cookies["user"]);
            cookies.Remove("age");

            if(cookies.ContainsKey("age")){
                Console.WriteLine(cookies["age"]);
            }else{
                System.Console.WriteLine("propriedade 'age' foi excluida");
            }

            System.Console.WriteLine("Size: " + cookies.Count + "\nAll Cookies: ");

            foreach (KeyValuePair<string, string> cook in cookies) {
                System.Console.WriteLine($"{cook.Key}: {cook.Value}");
            }
        }
    }
}
