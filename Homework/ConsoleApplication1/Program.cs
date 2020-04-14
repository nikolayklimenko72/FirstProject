using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 23;
            if (hour >= 6 && hour <= 11)
            {
                Console.WriteLine("Доброе утро");

            }
            if (hour >= 12 && hour <= 17)
            {
                Console.WriteLine("Добрый день");

            }
            if (hour >= 18 && hour <= 22)
            {
                Console.WriteLine("Добрый вечер");
            }
            if (hour >= 23 || hour <= 5)
            {
                Console.WriteLine("Доброй ночи");
            }

            Console.ReadKey();
        }
    }
}
