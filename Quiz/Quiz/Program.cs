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
            string answer1 = Console.ReadLine();

            if (answer1 == "2017")
            {
                Console.WriteLine("Верно.");
            }
            else
            {
                Console.WriteLine("Неверно.");
            }
            Console.Read();
        }
    }
}
