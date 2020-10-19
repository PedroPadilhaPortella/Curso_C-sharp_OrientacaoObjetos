using System;

namespace Devices.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            System.Console.WriteLine($"Combo Device Processing {document}");
        }
        public string Print(string document)
        {
            return $"Combo Device Print {document}";
        }
        public string Scan()
        {
            return "Combo Device Scan Result";
        }
    }
}