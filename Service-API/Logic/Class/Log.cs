using Service_API.Data.Class;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Logic
{
    class Log
    {
        // attributes
        private static Log instance = null;
        Queue<LogMessage> messageQueue;

        // properties
        public static Log Instance
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

        public Queue<LogMessage> MessageQueue { get => messageQueue; set => messageQueue = value; }

        // constructor
        private Log(){ }

        // methods
        public void CreateLog()
        {
            // TODO: create log from file
            foreach (LogMessage message in MessageQueue)
            {
                Debug.WriteLine("Log :: " + message);
            }
        }
    }
}
