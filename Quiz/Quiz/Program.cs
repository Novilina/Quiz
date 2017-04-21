using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой сейчас год?");
            int answer1 = int.Parse(Console.ReadLine());

            if (answer1 == 2017)
            {
                Console.WriteLine("Верно.");
            }
            else
            {
                Console.WriteLine("Неверно.");
            }


            Console.WriteLine("Сколько сейчас минут?");
            int answer2 = int.Parse(Console.ReadLine());

            if (answer2 == DateTime.Now.Minute)
            {
                Console.WriteLine("Верно.");
            }
            else
            {
                Console.WriteLine("Неверно.");
            }

            Console.WriteLine("Напишите текуший месяц.");
            int answer3 = int.Parse(Console.ReadLine());

            if (answer3 == DateTime.Now.Month)
            {
                Console.WriteLine("Верно.");
            }
            else
            {
                Console.WriteLine("Неверно.");
            }

            Console.WriteLine("В каком регионе нашей страны мы находимся?");
            int answer4 = int.Parse(Console.ReadLine());

            if (answer4 == 52)
            {
                Console.WriteLine("Верно.");
            }
            else
            {
                Console.WriteLine("Неверно.");
            }
            Console.ReadLine();
        }
    } 
}