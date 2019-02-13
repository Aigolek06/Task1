using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\testgit\primes.txt");
            string[] str = text.Split();
            FileStream fs = new FileStream(@"C:\testgit\output.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            int[] n = new int[str.Count()];
            bool ok = true;
            for (int i = 0; i < str.Length; i++)
            {
                ok = true;
                n[i] = int.Parse(str[i]);
                for (int j = 2; j * j <= n[i]; j++)
                {
                    if (n[i] % j == 0)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok == true & n[i] >= 2)
                {
                    sw.Write(n[i] + " ");
                }
            }
            sw.Close();
            fs.Close();
        }
    }
}