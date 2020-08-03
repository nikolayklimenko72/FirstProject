using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4];
            a[0] = 20;
            a[1] = 5;
            a[2] = 7;
            a[3] = 3;
            int sum = 0;
            Console.WriteLine("Исходные данные:");
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine(a[i]);
                sum += a[i];
            }
            Console.WriteLine("Sum = " + sum);
            Console.ReadKey();
        }
        
    }
}
