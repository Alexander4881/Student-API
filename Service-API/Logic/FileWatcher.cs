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
        // attributes
        private Thread fileWatcherThread;
        private string watchFolderPath;
        
        // properies
        public Thread FileWatcherThread { get => fileWatcherThread; set => fileWatcherThread = value; }
        public string WatchFolderPath { get => watchFolderPath; set => watchFolderPath = value; }

        /// <summary>
        /// a mrthod that get called when a file is created
        /// </summary>
        private void OnFileCreated()
        {
            // TODO: Check file type
            // TODO: Run CSV Converter
        }

        /// <summary>
        /// check the Integrity of the file
        /// </summary>
        /// <param name="path"> the path of the file that needs to be checked </param>
        /// <returns> true of the file can be used </returns>
        /// <returns> false if the file cant be used </returns>
        private bool CheckFileIntegrity(string path)
        {
            // TODO: Check file intregity be for file use
            return false;
        }
    }
}
