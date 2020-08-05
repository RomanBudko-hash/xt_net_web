using System;
using System.IO;

namespace __FILE_MANAGEMENT_SYSTEM
{
    internal static class FileSavior
    {
        internal static void SaveFiles(string [] files, string currentPath, string backupDir)
        {
            foreach (string file in files)
            {
                string fName = file.Substring(currentPath.Length + 1);

                try
                {
                    File.Copy(Path.Combine(currentPath, fName), Path.Combine(backupDir, fName), true);
                }

                catch (IOException copyError)
                {
                    Console.WriteLine(copyError.Message);
                }
            }
        }
    }
}
