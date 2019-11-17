using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой
//промежуток[0 - 14][15 - 35][36 - 50][50 - 100]. Если да, то укажите, в какой именно промежуток. Если
//пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то
//выводится соответствующее сообщение. 

namespace RangeDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0 до 100 (включительно)");
            byte value = Convert.ToByte(Console.ReadLine());
            if (value >= 0 && value <= 14)
                Console.WriteLine("Данное число {0} входит в диапазон чисел от 0 до 14", value);
            else if (value >= 15 && value <= 35)
            {
                Console.WriteLine("Данное число {0} входит в диапазон чисел от 15 до 35", value);
            }
            else if (value >= 36 && value <= 50)
            {
                Console.WriteLine("Данное число {0} входит в диапазон чисел от 36 до 50", value);
            }
            else if(value >= 51 && value <= 100)
            {
                Console.WriteLine("Данное число {0} входит в диапазон чисел от 51 до 100", value);
            }
            else 
            {
                Console.WriteLine("Вы ввели число {0}, которое не входит в диапазон чисел от 0 до 100", value);
            }


        }
    }
}
