using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public static class DocumentHelper
    {
        public static string parentDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AppFiles");
        public static string emailsDiretory = Path.Combine(parentDirectory, "Emails");
        public static string coursesDirectory = Path.Combine(parentDirectory, "Courses");
        public static void MakeDirectory(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void CopyFile(string source, string destination)
        {
            try
            {
                //File.Copy(sourceFilePath, destinationFilePath, true);  // Copy the file
                File.Copy(source, destination, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static bool IsDirectoryExists(string path)
        {
            return Directory.Exists(path);
        }
    }
}
