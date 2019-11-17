using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Дополнительное задание
            //Задание 1
            //Используя Visual Studio, создайте проект по шаблону Console Application.
            //Напишите программу русско - английский переводчик.Программа знает 10 слов о погоде.Требуется,
            //чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на
            //английском языке. Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести
            //сообщение, что такого слова нет.
            Console.WriteLine("Наш небольшой русско-английский словарь о погоде. ");

            Console.Write("Введите любое слово о погоде на русском языке: ");
            string wordWeather = Console.ReadLine();
            switch (wordWeather)
            {
                case "дождь":
                    Console.WriteLine("{0} - это слово на английском будет - rain", wordWeather);
                    break;
                case "ветренно":
                    Console.WriteLine("{0} - это слово на английском будет - windy", wordWeather);
                    break;
                case "прохладно":
                    Console.WriteLine("{0} - это слово на английском будет - cool", wordWeather);
                    break;
                case "тепло":
                    Console.WriteLine("{0} - это слово на английском будет - warm", wordWeather);
                    break;
                case "жарко":
                    Console.WriteLine("{0} - это слово на английском будет - hot", wordWeather);
                    break;
                case "туман":
                    Console.WriteLine("{0} - это слово на английском будет - fog", wordWeather);
                    break;
                case "снег":
                    Console.WriteLine("{0} - это слово на английском будет - snow", wordWeather);
                    break;
                case "слякоть":
                    Console.WriteLine("{0} - это слово на английском будет - slush", wordWeather);
                    break;
                case "солнечно":
                    Console.WriteLine("{0} - это слово на английском будет - sunny", wordWeather);
                    break;
                case "мороз":
                    Console.WriteLine("{0} - это слово на английском будет - frost", wordWeather);
                    break;
                case "оттепель":
                    Console.WriteLine("{0} - это слово на английском будет - thaw", wordWeather);
                    break;
                default:
                    Console.WriteLine("Такого слова в нашем словаре нет((");
                    break;
            }
        }
    }
}
