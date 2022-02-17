using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{

    class Program
    {
        static void inputarr(int[,]arr, int row, int column)
        {
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < row; ++i)
            {
                for(int j = 0; j < column; ++j)
                {
                    arr[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void task1(int row, int column, int[,] arr)
        {
            Console.WriteLine("Положительные элементы массива: ");
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < column; ++j)
                {
                    if (arr[i, j] > 0)
                    {
                        Console.WriteLine(arr[i, j]);
                    }
                }
            }
        }
        static double average(int row, int column, int[,] arr)
        {
            double sum = 0;
            double average = 0;
            Console.Write("Среднее арифметическое: ");
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < column; ++j)
                {
                    if (arr[i, j] > 0)
                    {
                        sum += arr[i, j];
                        average++;
                    }
                }
            }
            return (sum / average);
        }
        static double geometr(int row, int column, int[,] arr)
        {
            double mul = 1;
            int average = 0;
            Console.Write("Среднее геометрическое: ");
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < column; ++j)
                {
                    if (arr[i, j] > 0)
                    {
                        mul *= arr[i, j];
                        average++;
                    }
                }
            }
            return (mul / average);
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int [row, column];
            inputarr(arr,row,column);
            task1(row,column,arr);
            Console.WriteLine(average(row, column, arr));
            Console.WriteLine(geometr(row, column, arr));
            Console.ReadKey();
        }
    }
}
