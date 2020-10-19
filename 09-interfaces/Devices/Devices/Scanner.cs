namespace Devices.Devices
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            System.Console.WriteLine($"Scanner Processing {document}");
        }
        public string Scan()
        {
            return "Scanner Scan Result";
        }
    }
}