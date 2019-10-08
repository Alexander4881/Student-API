using Service_API.Logic.Events;
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
    class FileWatcher : IFileCreated
    {
        // attributes
        private ManualResetEventSlim eventLock = new ManualResetEventSlim(true);
        private Thread fileWatcherThread;
        private string watchFolderPath = @"C:\WatchFolder";
        private FileSystemWatcher watcher = new FileSystemWatcher();

        // properies
        public Thread FileWatcherThread { get => fileWatcherThread; set => fileWatcherThread = value; }
        public string WatchFolderPath { get => watchFolderPath; private set => watchFolderPath = value; }

        // event
        public event EventHandler FileCreated;

        // constructor
        public FileWatcher()
        {
            FileWatcherThread = new Thread(Run);
            FileWatcherThread.Start();
        }


        private void Run()
        {
            watcher.Path = WatchFolderPath;

            // Watch for changes in LastAccess and LastWrite times, and
            // the renaming of files or directories.
            watcher.NotifyFilter = NotifyFilters.FileName;

            // Only watch text files.
            watcher.Filter = "*.*";

            // Add event handlers.
            watcher.Created += OnFileCreated;

            // Begin watching.
            watcher.EnableRaisingEvents = true;

            while (true)
            {
                // wait for an event
                eventLock.Wait();
                // resets the event
                eventLock.Reset();
            }
        }

        /// <summary>
        /// a method that get called when a file is created
        /// </summary>
        private void OnFileCreated(object sender, FileSystemEventArgs e)
        {
            // wake the main thread
            eventLock.Set();
            FileCreated?.Invoke(sender, e);
        }
    }
}
