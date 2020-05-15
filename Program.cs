using System;

namespace LatihanPolymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            printer.show =  "Printer status ";
            printer.print = "The printer is printing";

            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor [1..3] : ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            IPrinters convert;

            if (nomorFormatData == 1)
                convert = new Epson();
            else if (nomorFormatData == 2)
                convert = new Canon();
            else
                convert = new LaserJet();

            convert.Convert(printer);
            Console.ReadKey();
        }
    }
}
