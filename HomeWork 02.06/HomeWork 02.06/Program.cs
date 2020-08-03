using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_02._06
{
    class Program
    {
        static void Main(string[] args)
        {
           	string[] Adresses = new string[4];
        	int[] Rooms = new int[4];
        	int[] Price = new int[3];

        	Adresses[0] = "ул. Ленина, 25";
        	Adresses[1] = "ул. Строителей, 3";
        	Adresses[2] = "Никитский бульвар, 16";

        	Rooms[0] = 3;
        	Rooms[1] = 1;
        	Rooms[2] = 2;

        	Price[0] = 55000;
        	Price[1] = 30000;
        	Price[2] = 75000;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Объявление №" + i.ToString()); // выводим заголовок объявления с его номером
                Console.WriteLine("Адрес: " + Adresses[i]); // с новой строки выводим адрес квартиры
                Console.WriteLine("Кол-во комнат: " + Rooms[i]); // с новой строки выводим кол-во комнат
            }
            Console.ReadKey();
            
        }
    }
}
