namespace Devices.Devices
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            System.Console.WriteLine($"Printer Processing {document}");
        }
        public string Print(string document)
        {
            return $"Printer Print {document}";
        }
    }
}