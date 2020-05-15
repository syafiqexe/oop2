using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LatihanPolymorphism2
{
    class Epson : IPrinters
    {
        public void Convert(Printer printer)
        {
            string epson = JsonConvert.SerializeObject(printer);

            Console.WriteLine("Hasil konversi \n");
            Console.WriteLine(epson);
        }
    }
}
