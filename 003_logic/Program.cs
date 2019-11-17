using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;
            Console.WriteLine("Уравнение №1 --> x={0}", x += y >> x++ * z);
            x = 5; y = 10; z = 15;
            Console.WriteLine("Уравнение №2 --> z={0}", z = ++x & y * 5);
            x = 5; y = 10; z = 15;
            Console.WriteLine("Уравнение №3 --> y={0}", y /= x + 5 | z);
            x = 5; y = 10; z = 15;
            Console.WriteLine("Уравнение №4 --> z={0}", z = x++ & y * 5);
            x = 5; y = 10; z = 15;
            Console.WriteLine("Уравнение №5 --> x={0}", x = y<< x++ ^z);
        }
    }
}
