using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Service_API.Logic
{
    class CSVConverter: IFullDataCopling
    {
        // attributes
        private Thread CSVConverterThread;
        private string path;

        public CSVConverter(string path)
        {
            this.path = path;
        }

        public List<Object> Convert()
        {
            using (var reader = new StreamReader(@"C:\Users\user\Downloads\Praktikoversigt-120919-094327.csv"))
            {
                List<object> dataObjectsList = new List<object>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('	');

                    Console.WriteLine(values);
                }
            }
        }
    }
}