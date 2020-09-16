using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";
            string upper = original.ToUpper();
            string lower = original.ToLower();
            string trim = original.Trim();

            System.Console.WriteLine($"ToUpper: -{upper}-");
            System.Console.WriteLine($"ToLower: -{lower}-");
            System.Console.WriteLine($"Trim: -{trim}-");

            int index1 = original.IndexOf("bc");
            int index2 = original.LastIndexOf("bc");
            string sb1 = original.Substring(6);
            string sb2 = original.Substring(6, 5);
            string rep1 = original.Replace('a', '@');
            string rep2 = original.Replace("abc", "PEDRO");

            System.Console.WriteLine($"IndexOf('bc'): {index1}");
            System.Console.WriteLine($"LastIndexOf('bc'): {index2}");
            System.Console.WriteLine($"Substring(10): {sb1}");
            System.Console.WriteLine($"Substring(3, 10): {sb2}");
            System.Console.WriteLine($"Replace('a', '@'): {rep1}");
            System.Console.WriteLine($"Replace('abc', 'PEDRO'): {rep2}");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            System.Console.WriteLine($"IsNullOrEmpty: {b1}");
            System.Console.WriteLine($"IsNullOrWhiteSpace: {b2}");
        }
    }
}
