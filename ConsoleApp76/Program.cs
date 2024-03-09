using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DFL;
using DFL2;
using DFL3;
using DFL4;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace ConsoleApp76
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Введите два числа:");
            double num = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Class1 p = new Class1();
            Class2 m = new Class2();
            Class3 d = new Class3();
            Class4 y = new Class4();
            Console.WriteLine($"Сумма: {p.A(num, num2)}");
            Console.WriteLine($"Разность: {m.B(num, num2)}");
            Console.WriteLine($"Произведение: {y.C(num, num2)}");
            try
            {
                Console.WriteLine($"Частное: {d.D(num, num2)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            TimeSpan elapsedTime = stopwatch.Elapsed;
            Console.WriteLine($"Время выполнения: {elapsedTime}");
            stopwatch.Stop();
            Console.ReadKey();
            ////int n = 27;
            ////string roma = ConvertRoman(n);
            ////Console.WriteLine($"");
            ////Console.ReadKey();
        }
    }
}