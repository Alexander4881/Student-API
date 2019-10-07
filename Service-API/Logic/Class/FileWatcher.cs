using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        private string watchFolderPath = @"C:\WatchFolder";
        
        // properies
        public Thread FileWatcherThread { get => fileWatcherThread; set => fileWatcherThread = value; }
        public string WatchFolderPath { get => watchFolderPath; private set => watchFolderPath = value; }

        // constructor
        public FileWatcher()
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = WatchFolderPath;

                // Watch for changes in LastAccess and LastWrite times, and
                // the renaming of files or directories.
                watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;

                // Only watch text files.
                watcher.Filter = "*.*";

                // Add event handlers.
                watcher.Created += OnFileCreated;

                // Begin watching.
                watcher.EnableRaisingEvents = true;

                while (true)
                {

                }
            }
        }


        /// <summary>
        /// a method that get called when a file is created
        /// </summary>
        private void OnFileCreated(object sender, FileSystemEventArgs e)
        {
            Debug.WriteLine("user created a file");
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
