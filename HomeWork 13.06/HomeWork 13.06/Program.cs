using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13._06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s;
            s = new string[6];
            s[0] = "Vladimir Morozov";
            s[1] = "Pavel Sarkisov";
            s[2] = "Oleg Astrahansev";
            s[3] = "Ilya Larev";
            s[4] = "Andrey Samsonov";
            s[5] = "Kiril Nikewin";

            string[] birth;
            birth = new string[6];
            birth[0] = "12/03/1995";
            birth[1] = "7/11/1994";
            birth[2] = "5/02/1992";
            birth[3] = "7/09/1993";
            birth[4] = "16/02/1996";
            birth[5] = "13/12/1992";

            for (int i = 0; i < birth.Length; i = i + 1)
            {
                Console.Write(s[i]);
                Console.WriteLine(" " + birth[i]);
            }
             //---------------------------
            for (int i = 0; i < s.Length; i = i + 1)
            {
                if (s[i] == "Vladimir Morozov")
                {
                    Console.WriteLine("--------------------------");
                    Console.Write(s[i] + " " + birth[i]);
                }
            }
           
            
                Console.ReadKey(); 
        }
        
    }
    
}
