using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_logic
{
//    Задание 2
//Известно, что у четных чисел младший бит имеет значение 0.
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Напишите программу, которая будет выполнять проверку чисел на четность.
//Предложите два варианта решения поставленной задачи.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение числа:");
            byte number = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("1-й вариант решения данной задачи:");
            byte resultFirst = (byte)(number % 2);
            if (resultFirst==0)
            {
                Console.WriteLine("{0} % 2 = {1} - вывод: введенное Вами число четное", number, resultFirst);
            }
            else
            {
                Console.WriteLine("{0} % 2 = {1} - вывод: введенное Вами число нечетное", number, resultFirst);
                
            }
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("2-й вариант решения данной задачи:");
            byte resultSecond = (byte)(number << 7);
            if (resultSecond == 0)
            {
                Console.WriteLine("{0} << 7 = {1} - вывод: введенное Вами число четное", number, resultSecond);
            }
            else
            {
                Console.WriteLine("{0} << 7 = {1} - вывод: введенное Вами число нечетное", number, resultSecond);

            }
        }
    }
}
