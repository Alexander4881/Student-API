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

                    // read the first line from the csv
                    reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        // get a new line from the csv
                        string csvLine = reader.ReadLine();
                        // get the csv data from the new line
                        string[] csvData = csvLine.Split('	');

                        // convert to a data object
                        ConvertCSVDataToObj(csvData);
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
        private List<object> ConvertCSVDataToObj(string[] csvData)
        {
            List<object> returneList = new List<object>();

            switch (csvData[10])
            {
                case "Skoleaftale":

                    break;

                case "Uddannelsesaftale":
                    // create user
                    User user = new User(csvData[5],csvData[6],);
                    returneList.Add(new User);

                    // create school Agreeement

                    // create School
                    break;

                case "Skolepraktik":

                    break;

                case "Skoleforløb":

                    break;
            }

            return null;
        }

        private DataTime GetDataTime(string dateDanishFormat)
        {

            byte day = byte.Parse(dateDanishFormat.Substring(0, 1));
            byte month = byte.Parse(dateDanishFormat.Substring(2, 3));
            byte year = byte.Parse();
            return new DateTime(year, month, day);
        }
    }
}