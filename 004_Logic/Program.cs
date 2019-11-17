using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Logic
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выслугу лет: ");
            byte lengthOfService = Convert.ToByte(Console.ReadLine());
            if (lengthOfService<=5)
            {
                Console.WriteLine("Ваша премия составляет 10% от заработанной платы");
            }
            else if (lengthOfService >5 && lengthOfService<= 10)
            {
                Console.WriteLine("Ваша премия составляет 15% от заработанной платы");
            }
            else if (lengthOfService > 10 && lengthOfService <= 15)
            {
                Console.WriteLine("Ваша премия составляет 25% от заработанной платы");
            }
            else if (lengthOfService > 15 && lengthOfService <= 20)
            {
                Console.WriteLine("Ваша премия составляет 35% от заработанной платы");
            }
            else if (lengthOfService > 20 && lengthOfService <= 25)
            {
                Console.WriteLine("Ваша премия составляет 45% от заработанной платы");
            }
            else 
            {
                Console.WriteLine("Ваша премия составляет 50% от заработанной платы");
            }
        }
    }
   
}
