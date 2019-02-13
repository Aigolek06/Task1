using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream(@"C:\testgit\Poly.txt", FileMode.Open, FileAccess.ReadWrite);
            //StreamReader sr = new StreamReader(fs);
            //string line = sr.ReadLine();
            string line = File.ReadAllText(@"C:\testgit\Poly.txt");
            bool ok = true;
            for(int i = 0; i < line.Count() / 2; i++)
            {
                if(line[i] != line[line.Count() - i - 1])
                {
                    ok = false;
                    break;
                }
            }
            if (ok)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}