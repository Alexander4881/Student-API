using Service_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Logic
{
    class Database : IDatabase, IDataInsert// IFullDataCopling
    {
        // attributes
        private Database instance = null;
        private readonly string dbConnectionString;

        // properties
        public Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
            private set 
            { 
                instance = value; 
            }
        }

        // constructor
        private Database(){ }

        public void InsertData(IList<object> data)
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }
    }
}
