using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;

            int result = 0;

            result = (x += y) >> (x++ * z);

            Console.WriteLine("{0}", result);

            result = ((z = ++x) & (y * 5));

            Console.WriteLine("{0}", result);

            result = (y /= x) + (5 | z);

            Console.WriteLine("{0}", result);

            result = x++ & (y * 5);

            Console.WriteLine("{0}", result);

            result = (x = y) << (x++ ^ z);

            Console.WriteLine("{0}", result);

            Console.ReadKey();
        }
    }
}
