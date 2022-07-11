using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace LatihanPolymorphism2
{
    public class ConvertToXml : IConvertObject
    {
        private TextWriter writer;

        public void Convert(Mahasiswa mhs)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Mahasiswa));
            serializer.Serialize(writer, mhs);

            string xml = writer.ToString();

            Console.WriteLine("hasil konversi ke XML:\n");
            Console.WriteLine(xml);
        }
    }
}
