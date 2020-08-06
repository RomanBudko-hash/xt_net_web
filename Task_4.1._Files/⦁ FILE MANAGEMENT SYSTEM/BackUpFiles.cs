using System;
using System.IO;

namespace __FILE_MANAGEMENT_SYSTEM
{
    internal class BackUpFiles
    {
        private static DateTime GetBackupTime()
        {
            Console.WriteLine("Enter a year, a month, a day separated by space");

            DateTime restorationDate;

            if (DateTime.TryParse(Console.ReadLine(), out restorationDate))
            {
                Console.WriteLine("Now write please a hour, which will be main for backup");

                restorationDate = restorationDate.AddHours(double.Parse(Console.ReadLine()));

                Console.WriteLine("Now write please a minute, which will be main for backup");

                restorationDate = restorationDate.AddMinutes(double.Parse(Console.ReadLine()));
            }

            return restorationDate;
        }

        internal void DeleteAllFiles()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Watcher.PathFileMonitoring);

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                file.Delete();
            }

            RecoveryNeedFiles();
        }

        private void RecoveryNeedFiles() // Надо доделать, но хз получится у меня за пол часа 
        {
            DateTime recoveryDate = GetBackupTime();

            string oldSource = Watcher.PathBackupFiles;

            string newSource = Watcher.PathFileMonitoring;

            foreach (var file in Directory.GetFiles(oldSource))
            {
                if (File.GetCreationTime(Path.Combine(oldSource, file.ToString())) == recoveryDate)
                {
                    Directory.Move(oldSource, newSource);
                }
                else
                {
                    Console.WriteLine("There is have not files from this date");
                }
            }
        }
    }
}
