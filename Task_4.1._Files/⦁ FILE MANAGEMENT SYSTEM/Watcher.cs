using System;
using System.IO;
using System.Threading;

namespace __FILE_MANAGEMENT_SYSTEM
{
    internal class Watcher
    {
        private static string PathFileMonitoring = @"C:\Users\irina.iroman\source\repos\RomanBudko-hash\xt_net_web\Task_4.1._Files\AllFilesForTask";

        private static string PathBackupFiles = @"C:\Users\irina.iroman\source\repos\RomanBudko-hash\xt_net_web\Task_4.1._Files\AllFilesForTask\HistoryOfChange";

        private static string[] TxtArray = Directory.GetFiles(PathFileMonitoring, "*.txt");
        #region SetsOfWatcher
        internal void BeginOfStartWatcher()
        {
            FileSystemWatcher watcher = new FileSystemWatcher(PathFileMonitoring, "*txt");

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
        #endregion
        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Name: " + e.Name + " act: " + e.ChangeType + " sourse " + e.FullPath);

            FileSavior.SaveFiles(TxtArray, PathFileMonitoring, PathBackupFiles);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Name: " + e.Name + " act: " + e.ChangeType + " sourse was " + e.FullPath);

            FileSavior.SaveFiles(TxtArray, PathFileMonitoring, PathBackupFiles);
        }

        private void OnRenamed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Name: " + e.Name + " act: " + e.ChangeType + " sourse " + e.FullPath);

            FileSavior.SaveFiles(TxtArray, PathFileMonitoring, PathBackupFiles);
        }
    }
}
