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
            
            int[] numbers;
            numbers = new int[5]; // Массив хранит номер региона.
            numbers[0] = 77;
            numbers[1] = 25;
            numbers[2] = 69;
            numbers[3] = 52;
            numbers[4] = 78;
            
            string[] s; // Массив хранит название городов.
            s = new string[5];
            s[0] = "Moscow";
            s[1] = "Vladivostok";
            s[2] = "Tverskaya Oblast";
            s[3] = "Nizhniy Novgorod";
            s[4] = "Sankt-Piterbyrg";

            int[] people;
            people = new int[5]; // Массив хранит количество людей в городах.
            people[0] = 12692466;
            people[1] = 606561;
            people[2] = 1260379;
            people[3] = 1252236;
            people[4] = 5398064;
           
            for (int i = 0; i < numbers.Length; i = i + 1)
            {
                Console.Write(s[i]);
                Console.Write("\t| " + "people: " + people[i] + " ");
                Console.WriteLine(numbers[i]);
                
                
            }
            Console.ReadKey();
        }
        
    }
}
