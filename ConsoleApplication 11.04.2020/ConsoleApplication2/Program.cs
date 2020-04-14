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
           
            /*"Проверка пароля":
Создаем строковую переменную
Просим пользователя ввести пароль
Сохраняем в нее текст, введенный с клавиатуры
Проверяем, совпадает ли введенный пароль с фиксированным паролем, и сообщаем пользователю результат проверки*/
            string s;
            Console.WriteLine("Введите пароль");
           
            s = Console.ReadLine();
            if ("12345" == s)
                
            {
                Console.WriteLine("Добро пожаловать в систему");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.WriteLine("Вы ввели:" + s);
            Console.ReadKey();
        }
    }
}
