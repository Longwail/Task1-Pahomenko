using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0;

            while (true) {
                try
                {
                    Console.WriteLine("Введите сторону равностороннего треугольника: ");
                    a = int.Parse(Console.ReadLine());
                    if (a <= 0) throw new Exception("Сторона не может быть отрицательной или нулевой");
                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");

                }

            }
                double p = (a * a * a) / 2;
                double r = a/2*Math.Sqrt(3);
                Console.WriteLine($"Радиус равен: {Math.Round(r,2)}");
        }
    }
}
