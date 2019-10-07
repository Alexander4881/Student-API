using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Logic
{
    class Database //: IFullDataCopling
    {
        // attributes
        private Database instance = null;
        private readonly string dbConnectionString;

        // properties
        internal Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
            private set => instance = value;
        }

        // constructor
        private Database(){ }
    }
}
