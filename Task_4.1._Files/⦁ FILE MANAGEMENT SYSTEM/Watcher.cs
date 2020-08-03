using System;
using System.IO;

namespace __FILE_MANAGEMENT_SYSTEM
{
    internal class Watcher
    {
        internal void BeginOfStartWatcher()
        {
            string pathFileMonitoring = @"C:\Users\irina.iroman\source\repos\RomanBudko-hash\xt_net_web\Task_4.1._Files\AllFilesForTask";

            FileSystemWatcher watcher = new FileSystemWatcher (pathFileMonitoring, "*txt");

            watcher.IncludeSubdirectories = true;

            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
            
            watcher.Changed += Watcher_Changed;
            watcher.Created += Watcher_Created;
            watcher.Deleted += Watcher_Deleted;
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            using (var writeLogs = new StreamWriter("Logs.txt", true))
            {
                writeLogs.WriteLine("Имя: "+ e.Name + " действие: " + e.ChangeType + " путь до файла " + e.FullPath);
            }
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
