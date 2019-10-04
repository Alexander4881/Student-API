using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service_API.Logic
{
    class FileWatcher
    {
        
        private Thread fileWatcherThread;
        
        public Thread FileWatcherThread { get => fileWatcherThread; set => fileWatcherThread = value; }
    }
}
