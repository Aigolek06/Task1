using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\user\source\repos\2a\Task4\path.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("I am just copying some text to my file");
            sw.Close();
            fs.Close();
            string sourcePath = @"C:\Users\user\source\repos\2a\Task4\path.txt";
            string targetPath = @"C:\Users\user\source\repos\2a\Task4\path1.txt";
            File.Copy(sourcePath, targetPath, true);
            File.Delete(sourcePath);
        }
    }
}