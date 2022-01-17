using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {
        static void task1()
        {
            Console.WriteLine("Введите число X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double u = 0;
            if(x <= -1)
            {
                u = (1 + Math.Abs(x)) / (Math.Pow(1 + x + Math.Pow(x, 2), 1.0 / 3.0));
            }
            if(x>-1 && x < 0)
            {
                u = (2 * Math.Log10(1 + Math.Pow(x, 2))) + ((1 + Math.Pow(Math.Cos(x), 4)) / (3 * (2 + x)));
            }
            else
            {
                u = Math.Pow((1 + x), 3.0 / 5.0);
            }
            Console.WriteLine($"Ваш ответ: {u}");
        }
        static void Main(string[] args)
        {
            task1();
            Console.ReadKey();
        }
    }
}
