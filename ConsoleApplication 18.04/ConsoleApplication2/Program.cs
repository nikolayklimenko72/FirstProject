using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; int summa = 0; int n = 10;
            for (i = 1; i <= n; i++)
            {
                summa = summa + i;
                Console.WriteLine(i);
            }
            Console.Write("summa:");
            Console.WriteLine(summa); 
            Console.ReadKey();
        }
        
    }
    
}
