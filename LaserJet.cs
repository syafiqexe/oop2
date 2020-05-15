using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanPolymorphism2
{
    class LaserJet : IPrinters
    {
        public void Convert(Printer printer)
        {
            string Laser = string.Format("{0},{1}" , printer.show, printer.print);

            Console.WriteLine("Hasil Konversi \n");
            Console.WriteLine(Laser);
        }
    }
}
