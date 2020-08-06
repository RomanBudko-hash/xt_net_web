using System;
using System.IO;

namespace __FILE_MANAGEMENT_SYSTEM
{
    internal class Watcher
    {
        private static string PathFileMonitoring = @"C:\Users\irina.iroman\source\repos\RomanBudko-hash\xt_net_web\Task_4.1._Files\AllFilesForTask";

        private static string PathBackupFiles = @"C:\Users\irina.iroman\source\repos\RomanBudko-hash\xt_net_web\Task_4.1._Files\AllFilesForTask\HistoryOfChange";
        #region SetsOfWatcher
        internal void BeginOfStartWatcher()
        {
            FileSystemWatcher watcher = new FileSystemWatcher(PathFileMonitoring, "*txt");

            watcher.IncludeSubdirectories = false;
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.LastAccess;

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnChanged);

            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Press l for exit");

            while (Console.ReadLine() != "l") ;
        }
        #endregion
        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Name: " + e.Name + " act: " + e.ChangeType + " sourse " + e.FullPath);

            FileSavior.SaveFiles(e.Name, PathFileMonitoring, PathBackupFiles);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Name: " + e.Name + " act: " + e.ChangeType + " sourse was " + e.FullPath);
        }
    }
}
