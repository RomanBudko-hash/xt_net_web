using System;

namespace __FILE_MANAGEMENT_SYSTEM
{
    internal static class ProvisionOfFunctions
    {
        internal static void ChoiceFunction()
        {
            Console.WriteLine("Please, choose a function");
            Console.WriteLine("1. Observation");
            Console.WriteLine("2. Back up of changes");

            if (int.TryParse(Console.ReadLine(), out int x) && x > 0 && x < 3)
            {
                ContinueAfterCheck(x);
            }
            else
            {
                throw new ArgumentException("You are can to enter only 1 or 2");
            }
        }

        private static void ContinueAfterCheck(int inputNumber)
        {
            switch (inputNumber)
            {
                case 1:
                    Monitoring();
                    break;

                case 2:
                    Backuping();
                    break;
            }
        }

        private static void Backuping()
        {
            //FileSavior.SaveFiles();
        }

        //private static DateTime GetBackupTime()
        //{
        //    Console.WriteLine("Enter a year, a month, a day separated by space");

        //    DateTime restorationDate;

        //    if (DateTime.TryParse(Console.ReadLine(), out restorationDate))
        //    {
        //        Console.WriteLine("Now write please a hour, which will be main for backup");

        //        restorationDate = restorationDate.AddHours(double.Parse(Console.ReadLine()));

        //        Console.WriteLine("Now write please a minute, which will be main for backup");

        //        restorationDate = restorationDate.AddMinutes(double.Parse(Console.ReadLine()));
        //    }

        //    return restorationDate;
        //}

        private static void Monitoring()
        {
            Watcher watcher = new Watcher(); 
            watcher.BeginOfStartWatcher();
        }
    }
}
