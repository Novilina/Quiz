using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int rightAnswerCount = 0;
            Console.WriteLine("Вопрос №1");
            Console.WriteLine("В каком году произошла Бородинская битва?");
            Console.WriteLine("1) 1456");
            Console.WriteLine("2) 2016");
            Console.WriteLine("3) 1812");
            Console.WriteLine("4) 981");
            var consoleKey1 = Console.ReadKey().Key;
            Console.WriteLine();
            if (consoleKey1 == ConsoleKey.NumPad3 || consoleKey1 == ConsoleKey.D3)
            {
                Console.WriteLine("Верно.");
                rightAnswerCount = rightAnswerCount + 1;
            }
            else
            {
                Console.WriteLine("Неверно.");

            }

            Console.WriteLine("Вопрос №2");
            Console.WriteLine("Советское название г. Нижний Новгород.");
            Console.WriteLine("1) Урюпинск");
            Console.WriteLine("2) Магадан");
            Console.WriteLine("3) Шоколадный");
            Console.WriteLine("4) Горький");
            var consoleKey2 = Console.ReadKey().Key;
            Console.WriteLine();
            if (consoleKey2 == ConsoleKey.NumPad4 || consoleKey2 == ConsoleKey.D4)
            {
                Console.WriteLine("Верно.");
                rightAnswerCount = rightAnswerCount + 1;
            }
            else
            {
                Console.WriteLine("Неверно.");

            }

            Console.WriteLine("Вопрос №3");
            Console.WriteLine("В каком году был основан г. Санкт-Петербург?");
            Console.WriteLine("1) 36 г. до н.э.");
            Console.WriteLine("2) 1703");
            Console.WriteLine("3) 305");
            Console.WriteLine("4) 9064");
            var consoleKey3 = Console.ReadKey().Key;
            Console.WriteLine();
            if (consoleKey3 == ConsoleKey.NumPad2 || consoleKey3 == ConsoleKey.D2)
            {
                Console.WriteLine("Верно.");
                rightAnswerCount = rightAnswerCount + 1;
            }
            else
            {
                Console.WriteLine("Неверно.");

            }

            Console.WriteLine("Вопрос №4");
            Console.WriteLine("Кто основал Москву?");
            Console.WriteLine("1) Юрий Долгорукий");
            Console.WriteLine("2) Петр Кривоногий");
            Console.WriteLine("3) Иван Калита");
            Console.WriteLine("4) Всеволод Большое Гнездо");
            var consoleKey4 = Console.ReadKey().Key;
            Console.WriteLine();
            if (consoleKey4 == ConsoleKey.NumPad1 || consoleKey4 == ConsoleKey.D1)
            {
                Console.WriteLine("Верно.");
                rightAnswerCount = rightAnswerCount + 1;
            }
            else
            {
                Console.WriteLine("Неверно.");

            }

            int mark = 1 + rightAnswerCount;
            Console.WriteLine("Ваша оценка - " + mark);
            
            Console.ReadLine();

        }
    }
}
