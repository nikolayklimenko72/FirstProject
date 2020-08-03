using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctPin;
            correctPin = "123";
            Console.WriteLine("Введите пин-код");

            string pin;
            pin = Console.ReadLine();
            if (pin == correctPin)
            {
                Console.Write("Доступ предоставлен");

            }
            else
            {
                Console.Write("В доступе отказано");
            }
            Console.ReadKey();
        }
    }
}
