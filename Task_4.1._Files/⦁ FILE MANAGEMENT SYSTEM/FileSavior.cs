using System;
using System.IO;

namespace __FILE_MANAGEMENT_SYSTEM
{
    internal static class FileSavior
    {
        internal static void SaveFiles(string nameOfFile, string currentPath, string backupDir)
        {
            try
            {
                string sourceFileName = Path.Combine(currentPath, nameOfFile);
                File.Copy(sourceFileName, Path.Combine(backupDir, nameOfFile), false);
            }

            catch (IOException copyError)
            {
                Console.WriteLine(copyError.Message);
            }
        }
    }
}
