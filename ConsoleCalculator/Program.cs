using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 2
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу - консольный калькулятор.
//Создайте две переменные с именами operand1 и operand2. Задайте переменным некоторые
//произвольные значения.Предложите пользователю ввести знак арифметической операции. Примите
//значение, введенное пользователем, и поместите его в строковую переменную sign.
//Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
//Выведите на экран результат выполнения арифметической операции.
//В случае использования операции деления, организуйте проверку попытки деления на ноль. И если
//таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке
//пользователя. 

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое значение первого числа:");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите любое значение второго числа:");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знак арифметической операции (+, -, *, /, %) : ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2);
                    break;
                case "/":
                        if (operand2 != 0)
                        {
                            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, operand1 / operand2);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ваше второе число равно {0}, а на ноль делить нельзя!", operand2);
                            break;
                        }
                case "%":
                    Console.WriteLine("{0} % {1} = {2}", operand1, operand2, operand1 % operand2);
                    break;
                default:
                    Console.WriteLine("Вы ввели неверный знак арифметической операции");
                    break;
            }
        }
    }
}
