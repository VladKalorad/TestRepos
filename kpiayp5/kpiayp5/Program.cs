using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpiayp5
{
    class Program
    {
        static int Nod(int a, int b)
        {
            int x = 0;
            if (a<b)
            {
                x = a;
            }
            else
            {
                x = b;
            }
            for (int i = x; i > 1; i--)
                if (((a % i) == 0) & ((b % i) == 0))
                {
                    return i;
                }
            return 1;
        }
        static void Check(int[]arr)
        {
            int[] newarr = new int[2];
            int nok = arr[0];
            for(int i =0; i < arr.Length;++i)
            { 
                nok = (nok * arr[i]) / Nod(nok, arr[i]);
                newarr[0] = Nod(nok, arr[i]);
                newarr[1] = nok;
            }
            for (int j = 0; j < newarr.Length; j++)
            {
                Console.WriteLine($"Новый массив:{newarr[j]}");
            }
            Console.WriteLine($"Нок = {nok}");

        }
        public static void InputArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static int FirstEven(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    return arr[i];
                   
                }
            }
            return 0;
        }

        public static void PlusPlus(int[] arr)
        {
            int num = FirstEven(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr[i] += num;
                }
                Console.WriteLine(arr[i]); ;
            }
        }
        static void PrintArr(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы массива: ");
            int[] arr = new int[n];
            InputArr(arr);
            //Console.WriteLine(FirstEven(arr));
            //PlusPlus(arr);
            Check(arr);
            Console.ReadKey();
        }
    }
}
