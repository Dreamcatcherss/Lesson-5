using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = 4876;

            double result = 0;
            string prize;

            Console.Write("Введите вашу выслугу полных лет, расчитаем премию от вашей зарплаты в 4876 грн:  ");

            prize = Console.ReadLine();

            if (Convert.ToInt32(prize) >=0 && Convert.ToInt32(prize) < 5)
            {
                result = cash * 0.1;
                Console.WriteLine("Ваша премия будет сотавлять {0} грн", result );
                result = cash * 0.1 + cash;
                Console.WriteLine("А ваша заработная плата в сумме за месяц будет составлять:  {0} грн", result);
            }

            else if (Convert.ToInt32(prize) >= 5 && Convert.ToInt32(prize) < 10)
            {
                result = cash * 0.15;
                Console.WriteLine("Ваша премия будет сотавлять {0} грн", result);
                result = cash * 0.15 + cash;
                Console.WriteLine("А ваша заработная плата в сумме за месяц будет составлять:  {0} грн", result);
            }

            else if (Convert.ToInt32(prize) >= 10 && Convert.ToInt32(prize) < 15)
            {
                result = cash * 0.25;
                Console.WriteLine("Ваша премия будет сотавлять {0} грн", result);
                result = cash * 0.25 + cash;
                Console.WriteLine("А ваша заработная плата в сумме за месяц будет составлять:  {0} грн", result);
            }

            else if (Convert.ToInt32(prize) >= 15 && Convert.ToInt32(prize) < 20)
            {
                result = cash * 0.35;
                Console.WriteLine("Ваша премия будет сотавлять {0} грн", result);

                result = cash * 0.35 + cash;
                Console.WriteLine("А ваша заработная плата в сумме за месяц будет составлять:  {0} грн", result);
            }

            else if (Convert.ToInt32(prize) >= 20 && Convert.ToInt32(prize) < 25)
            {
                result = cash * 0.45;
                Console.WriteLine("Ваша премия будет сотавлять {0} грн", result);

                result = cash * 0.45 + cash;
                Console.WriteLine("А ваша заработная плата в сумме за месяц будет составлять:  {0} грн", result);
            }

            else if (Convert.ToInt32(prize) >= 25)
            {
                result = cash * 0.5;
                Console.WriteLine("Ваша премия будет сотавлять {0} грн", result);

                result = cash * 0.5 + cash;
                Console.WriteLine("А ваша заработная плата в сумме за месяц будет составлять:  {0} грн", result);
            }

            Console.ReadKey();
            
        }
    }
}
