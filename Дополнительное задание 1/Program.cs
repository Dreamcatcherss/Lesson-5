using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дополнительное_задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string val;

            Console.WriteLine("Введите число, проверим является ли оно степенью двойки или нет");

            val = Console.ReadLine();

            if (Convert.ToUInt32(val) >= 2 && (Convert.ToUInt32(val) & (Convert.ToUInt32(val) - 1)) == 0)

                Console.WriteLine("Число:   " + val + "   Является");


            else

                Console.WriteLine("Число:   " + val + "   Не является");
            

            Console.ReadKey();
        }
    }
}
