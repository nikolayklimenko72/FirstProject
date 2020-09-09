using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        static int test = 5;

        static void Main(string[] args)
        {
            Hello("John", 12);
            Hello("Bob", 20);
            Hello("Sindy", 15);
            Console.WriteLine("Специальное предложение при скидке 12%: " + SpecialOffer(12));
            Console.WriteLine("Специальное предложение при скидке 20%: " + SpecialOffer(20));
            Console.WriteLine("Специальное предложение при скидке 15%: " + SpecialOffer(15)); 
            Console.ReadKey();
        }

        static void Hello(string name, int discount)
        {
            Console.Write("Hello, " + name);
            Console.WriteLine(". Your discount is " + discount + "%");
            Console.WriteLine("");
            ShowCart(name);
            Console.WriteLine("==============================");

        }

         static void ShowCart(string name)
        {
            if (name == "John")
            {
                Console.WriteLine("1. Яблоко 12 шт.");
            }

            if (name == "Bob")
            {
                Console.WriteLine("1. Пицца Маргарита");
            }

            if (name == "Sindy")
            {
                Console.WriteLine("1. Сельдерей");
            }


        }

         static int SpecialOffer(int discount)
         {
             int SpecialDiscount = discount * 2;
             return SpecialDiscount;
         }
    }
}
