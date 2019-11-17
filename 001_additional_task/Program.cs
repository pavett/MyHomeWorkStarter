using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 1
//Известно, что у чисел, которые являются степенью двойки, только один бит имеет значение 1.
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу, которая будет выполнять проверку – является ли указанное число степенью
//двойки или нет. 

namespace _001_additional_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = number & (number - 1);
            if (result==0)
            {
                Console.WriteLine("Число {0} является степенью двойки", number);
            }
            else
            {
                Console.WriteLine("Число {0} не является степенью двойки", number);
            }
        }
    }
}
