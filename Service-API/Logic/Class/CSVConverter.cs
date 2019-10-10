using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Service_API.Data.Interface;
using Service_API.Data.Class;
using Service_API.Logic.Class;

namespace Service_API
{
    class CSVConverter : IConvert//, IFullDataCopling
    {
        // attributes
        private string path;

        public CSVConverter(string path)
        {
            this.path = path;
        }

        public List<object> Convert()
        {
            try
            {
                using (var reader = new StreamReader(path))
                {
                    // the data object we will retune
                    List<object> dataObjectsList = new List<object>();

                    while (!reader.EndOfStream)
                    {
                        // read the first line
                        reader.ReadLine();
                        string csvLine = reader.ReadLine();
                        string[] csvData = csvLine.Split('	');
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"EXCEPTION CAUGHT: {ex}");
                // LOG
            }
            return null;
        }

        /// <summary>
        /// a method to create a data object from a string array
        /// </summary>
        /// <param name="csvData"> the csv data </param>
        /// <returns> CSVData Object </returns>
        private CSVData ConvertCSVDataToObj(string[] csvData)
        {


            return null;
        }
    }
}