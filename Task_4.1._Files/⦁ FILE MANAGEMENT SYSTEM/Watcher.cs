using System;
using System.IO;

namespace __FILE_MANAGEMENT_SYSTEM
{
    internal class Watcher
    {
        private string pathFileMonitoring = @"C:\Users\irina.iroman\source\repos\RomanBudko-hash\xt_net_web\Task_4.1._Files\AllFilesForTask";

        internal void BeginOfStartWatcher()
        {
            FileSystemWatcher watcher = new FileSystemWatcher(pathFileMonitoring, "*txt");

            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.LastAccess;

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Press l for exit");

            while (Console.ReadLine() != "l") ;
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Name: " + e.Name + " act: " + e.ChangeType + " sourse " + e.FullPath);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Name: " + e.Name + " act: " + e.ChangeType + " sourse was " + e.FullPath);
        }

        private void OnRenamed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Name: " + e.Name + " act: " + e.ChangeType + " sourse " + e.FullPath);
        }
    }
}
