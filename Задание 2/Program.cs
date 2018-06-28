using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string chislo;

            Console.Write("Введите ваше число, проверим оно четное или нет:  ");

            chislo = Console.ReadLine();

            
            if ((Convert.ToInt32(chislo) % 2) == 0)
            {
                Console.WriteLine("Четное");
            }

            else
            {
                Console.WriteLine("Нечетное");
            }



            Console.ReadKey();
        }
    }
}
