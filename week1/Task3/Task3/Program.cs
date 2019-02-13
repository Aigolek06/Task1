using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
        class Program
    {
        static void method(string a, string b)
        {
            int n = int.Parse(a);
            string[] arr = b.Split(' ');
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(arr[i]);
                array[i] = x;

            }
            List<int> list = new List<int>();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    list.Add(array[i]);
                }
            }
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }

        static void Main(string[] args)
        {
         
           string n = Console.ReadLine();
            string s = Console.ReadLine();
            method(n, s);
            Console.ReadLine();
         }
        
    }
 }


