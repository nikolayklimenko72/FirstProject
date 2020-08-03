using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = new int[10];
            numbers[0] = 51;
            numbers[1] = 15;
            numbers[2] = 55;
            numbers[3] = 89;
            numbers[4] = 23;
            numbers[5] = 80;
            numbers[6] = 23;
            numbers[7] = 11;
            numbers[8] = 42;
            numbers[9] = 73;

            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] > 50)
                {
                    Console.WriteLine(numbers[i]);
                }
                else
                {
                    Console.WriteLine("*");
                }
            }
            Console.ReadKey();
            

        }
    }
}
