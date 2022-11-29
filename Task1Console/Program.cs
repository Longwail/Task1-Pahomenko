using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите сторону a");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите сторону b");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введиет сторону с");
                    c = int.Parse(Console.ReadLine());

                    if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Стороны треугольника не могут быть меньше или равны нулю");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");

                }
            }

            if (a < b + c && b < a + c && c < a + b)
                Console.WriteLine("Существует");
            else
                Console.WriteLine("Не существует");


        }
    }
}
