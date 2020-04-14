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
            int X, Y = 10;
            X = 5;
            bool b;
            b = X > Y;
            // if (X == 5 || Y == 10)
            bool ShopIsOpen;
            if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 22)
            {
                ShopIsOpen = true;
            }
            else
            {
                ShopIsOpen = false;
            }
            if (ShopIsOpen)
            {
                Console.WriteLine("Магазин открыт");
            }

            Console.ReadKey();
        }
    }
}
