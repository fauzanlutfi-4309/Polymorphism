using System;

using Newtonsoft.Json;

namespace LatihanPolymorphism2
{
    class ConvertToJson : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            string json = JsonConvert.SerializeObject(mhs);

            Console.WriteLine("hasil konversi ke json:\n");
            Console.WriteLine(json);
        }
    }
}
