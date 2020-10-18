using System;
using Devices.Devices;

namespace Devices
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() {SerialNumber = 167845};
            p.ProcessDoc("A random text");
            Console.WriteLine(p.Print("My schedule from next week"));

            Scanner s = new Scanner() {SerialNumber = 453199};
            s.ProcessDoc("An email from my boss");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() {SerialNumber = 345322};
            c.ProcessDoc("Course Conclusion Work");
            System.Console.WriteLine(c.Print("A personal document"));
            System.Console.WriteLine(c.Scan());
        }
    }
}
