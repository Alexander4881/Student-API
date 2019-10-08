using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Service_API.Data.Interface;

namespace Service_API
{
    class CSVConverter: IConvert, IFullDataCopling
    {
        // attributes
        private Thread CSVConverterThread;
        private string path;

        public CSVConverter(string path)
        {
            this.path = path;
        }

        //public List<Object> Convert()
        public void Convert()
        {
            try
            {
                using (var reader = new StreamReader(path))
                {
                    List<object> dataObjectsList = new List<object>();

                    int readerLine = 0;
                    var collomsTitles = new List<string>();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split('	');

                        Debug.WriteLine($"row {readerLine}  line: {line}");

                        if (readerLine == 0)
                        {
                            Debug.Write($"   row {readerLine}   First line, using row as colloms title:  ");
                            foreach (var value in values)
                            {
                                collomsTitles.Add(value);
                                Debug.Write($"{value}, ");
                            }
                            Debug.WriteLine("");
                        }
                        else
                        {
                            for (int i = 0; i < values.Length; i++)
                            {
                                if (values[i] != "")
                                {
                                    Debug.WriteLine($"   row: {readerLine}   title: {collomsTitles[i]}   value: {values[i]}");

                                    
                                }
                            }
                        }



                        readerLine++;
                    }
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"EXCEPTION CAUGHT: {ex}");
                // LOG
            }
        }

        public bool CreateCompany()
        {
            
        }

        public bool CreateEducation()
        {
            throw new NotImplementedException();
        }

        public bool CreateEducationAgreement()
        {
            throw new NotImplementedException();
        }

        public bool CreateEducationAgreementCatagory()
        {
            throw new NotImplementedException();
        }

        public bool CreateEducationAgreementOrigin()
        {
            throw new NotImplementedException();
        }

        public bool CreateEducationAgreementSubType()
        {
            throw new NotImplementedException();
        }

        public bool CreateEducationAgreementType()
        {
            throw new NotImplementedException();
        }

        public bool CreateeducationalConnection()
        {
            throw new NotImplementedException();
        }

        public bool CreateLearningActivity()
        {
            throw new NotImplementedException();
        }

        public bool CreateLogDatabseUpdate()
        {
            throw new NotImplementedException();
        }

        public bool CreateSchool()
        {
            throw new NotImplementedException();
        }

        public bool CreateSchoolAgreement()
        {
            throw new NotImplementedException();
        }

        public bool CreateSchoolCouse()
        {
            throw new NotImplementedException();
        }

        public bool CreateSpecialAgreement()
        {
            throw new NotImplementedException();
        }

        public bool CreateSpecialAgreementList()
        {
            throw new NotImplementedException();
        }

        public bool CreateUser()
        {
            throw new NotImplementedException();
        }

        public bool CreateUserInformation()
        {
            throw new NotImplementedException();
        }

        public bool ICreateLog()
        {
            throw new NotImplementedException();
        }
    }
}