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
        // used for checking the physical folder in the user machine
        public static string parentDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AppFiles");
        public static string emailsDiretory = Path.Combine(parentDirectory, "Emails");
        public static string coursesDirectory = Path.Combine(parentDirectory, "Courses");
        // used for inserting in database, we used relative paths here so that the db can work in different environements
        public static string parentRelativePath = $"bin\\debug\\AppFiles";
        public static string emailsRelativePath = Path.Combine(parentRelativePath, "Emails");
        public static string coursesRelativePath = Path.Combine(parentRelativePath, "Courses");
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
                File.Copy(source, destination, false);
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

        public static bool IsFileExists(string path)
        {
            return File.Exists(path);
        }

        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }
    }
}
