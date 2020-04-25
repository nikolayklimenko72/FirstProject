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
            Console.WriteLine("Введите число:");
            string s = Console.ReadLine();
            int x = int.Parse(s);
            if (x > 10)
            
            {
                Console.Write("Ваше число больше десяти");
            }
            Console.ReadKey();
        }
    
    }
    
}
