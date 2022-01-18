using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Program
    {
        static void laba3()
        {
            double y = 0;
            for(double xn = 0.1; xn < 1; xn+=0.09)
            {
                y = ((1 + Math.Pow(xn, 2)) / 2) * ((1 * Math.Atan(xn)) - (xn / 2));
                Console.WriteLine($"y = {y}");
            }
        }
        static void laba31()
        {
            double sum = 0;
            for(int i = 99; i < 1000; i++)
            {
                if(i % 2 == 0)
                {
                    sum += Math.Pow(i, 3);
                    
                }
            }
            Console.WriteLine(sum);
        }
        static bool laba312()
        {
            Console.WriteLine("Введите число X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i < x; ++i)
            {
                if( x % i == 0)
                {
                    return false;
                }
               
            }
            return true;
        }
        static void Main(string[] args)
        {
          //  laba3();
            //laba31();
            laba312();
            Console.WriteLine(laba312());
            Console.ReadKey();
        }
    }
}
