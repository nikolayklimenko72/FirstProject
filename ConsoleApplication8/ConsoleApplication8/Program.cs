using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLoyalCustomer;
            isLoyalCustomer = false;

            int personalDiscount;
            personalDiscount = 12;

            Console.WriteLine("Добро пожаловать");
            if (isLoyalCustomer == true)
            {
                if (personalDiscount < 10)
                {
                    Console.Write("Ваша скидка " + personalDiscount + "%,");
                    Console.WriteLine(" вам зачислен подарок в размере 300 рублей.");


                }
                else
                {
                    Console.WriteLine("Ваша скидка " + personalDiscount + "%");
                }
            }
            else
            {
                Console.WriteLine("Ваш аккаунт не найден. Начать регистрацию?"); // Записать ответ в виде пароля.

                string answer;// Создаем строковую переменную для хранения ответа пользователя
                 // Записываем в эту переменную то что пользователь ввёл с клавиатуры
                Console.WriteLine("Хотите ли вы зарегестрироваться?"); // Проверяем: если это ответ да, то выводим сообщение "вы зарегестрированы"
                answer = Console.ReadLine(); 
                if (answer == "Yes" || answer == "yes" || answer == "Да" || answer == "да") 
                {
                    Console.WriteLine("Вы зарегестрированы. Вам доступны персональные скидки и предложения");
                }
              
                else // Иначе (else) выводим сообщение "вам недоступны персональные скидки и предложения"
                {
                    Console.Write("Вам недоступны персональные скидки и предложения");
                }
                
            }
            Console.ReadKey();
        }
    }
}
