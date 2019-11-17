using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Используя теорему Де Моргана, преобразуйте исходное выражение A | B, в эквивалентное выражение.

namespace _002_additional_task
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;

            bool resultFirst =A | B;
            bool resultSecond = !(!A & !B);
            Console.WriteLine("{0} | {1} - К данному логическому выражению применим теорему Де Моргана:", A, B);
            Console.WriteLine("!(!{0} & !{1})", A, B);
            if (resultFirst==resultSecond)
            {
                Console.WriteLine("Получили 2 соответствующих результата: {0} и {1}, которые равны, а значит мы преобразовали правильно.", resultFirst, resultSecond);
            }
            else
            {
                Console.WriteLine("Получили 2 соответствующих результата: {0} и {1}, которые не равны, а значит мы преобразовали неправильно.", resultFirst, resultSecond);
            }


        }
    }
}
