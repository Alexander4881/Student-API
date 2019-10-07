using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Logic
{
    class Log
    {
        // attributes
        private static Log instance = null;

        // properties
        public Log Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Log();
                }
                return instance;
            }
            private set 
            { 
                instance = value;
            }
        }

        // constructor
        private Log(){ }

        // methods
        public void CreateLog()
        {
            // TODO: create log from file
        }
    }
}
