using System;

using System.IO;
using System.Xml.Serialization;

namespace LatihanPolymorphism2
{
    public class Canon : IPrinters
    {
        public void Convert (Printer printer)
        {
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Printer));
                serializer.Serialize(writer, printer);

                string canon = writer.ToString();

                Console.WriteLine("Hasil Konversi \n");
                Console.WriteLine(canon);
            }

        }
    }
}
