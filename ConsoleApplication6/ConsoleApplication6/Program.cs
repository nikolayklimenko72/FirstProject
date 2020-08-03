using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] street = new string[5];
            street[0] = "Laurel Canyon Boulevard";
            street[1] = "Ocean Avenue";
            street[2] = "Rodeo Drive";
            street[3] = "Wilshire Boulevard";
            street[4] = "Santa Monica Boulevard";

            string search;
            search = "Santa Monic Boulevard";
            bool isFound;
            isFound = false;
            
            for (int i = 0; i < 5; i++)
            {
                if (search == street[i])
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
                    

            }
            if (isFound == false)
            {
                Console.WriteLine("Улица не найдена");
            }
            Console.ReadKey();

        }
    }
}