using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    
    class Program
      
    {
        
        static void Main(string[] args)
        {
            Note Note1 = new Note();
            Note1.Title = "Hello World";
            Note1.Text = "Пончик";
            Note[] Notes = new Note[5];
            for (int i = 0; i < Notes.Length; i++)
            {
                Notes[i] = new Note();
                
                
            }
            Notes[0].Title = "Обед";
            Notes[0].Text = "Горячий суп";
            Notes[0].DateCreation = "18/08/2020";


            Notes[1].Title = "Ужин";
            Notes[1].Text = "Думаю о нем уже часа четыре";
            Notes[1].DateCreation = "12/08/2020";

            for (int i = 0; i < Notes.Length; i++)
            {
                Console.WriteLine("Заметка №" + i + ":");
                Console.WriteLine(Notes[i].Title);
                Console.Write(Notes[i].Text + "|");
                Console.WriteLine(Notes[i].DateCreation);
                Console.WriteLine(" ");
            }
                Console.ReadKey();
            
           
        }
        
    }
}
