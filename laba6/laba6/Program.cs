using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    class Program
    {
        public static void Task1_1()
        {
            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();
            char[] s_zxc = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < s_zxc.Length; i++)
            {
                if (s_zxc.Length % 5 == 0)
                {
                    if (s_zxc[i] == '(' || s_zxc[i] == ')')
                    {
                        ++count;
                    }
                }
                else
                {
                    Console.WriteLine("Не кратно пяти");
                }
            }
            Console.WriteLine($"Количество скобок в строке:{count} ");
        }
        public static void Task1_2()
        {
            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();
            char s1 = '(';
            char s2 = ')';
            int count = 0;
            for (int i = 0; i <s.Length; i++)
            {
                if (s.Length % 5 == 0&& (Convert.ToChar(s[i]) == s1 || s[i] == s2))
                {
                        ++count;
                }
            }
            if (s.Length % 5 != 0)
                Console.WriteLine("не кратно");
            Console.WriteLine($"Количество скобок в строке:{count} ");
        }
        public static void Task1_3()
        {
            StringBuilder str1 = new StringBuilder("Приве( как дела(", 40);
            char str2 = '(';
            int count = 0;
            for (int i = 0; i < str1.Length; ++i)
            {
                if (str1[i].Equals('('))
                {
                    ++count;
                }

            }
            Console.WriteLine(str1);
            Console.WriteLine(count);
        }
        public static void Task2()
        {
            Console.WriteLine("Введите знак");
            string s = Console.ReadLine();
            double f1 = Convert.ToDouble(Console.ReadLine());
            double f2 = Convert.ToDouble(Console.ReadLine());
            switch (s)
            {
                case "+":
                    double sum = f1 + f2;
                    string result = String.Format("{0:c}",sum);
                    Console.WriteLine(result);
                    break;
                case "-":
                    double min = f1 - f2;
                    string resultmin = String.Format("{0:c}", min);
                    Console.WriteLine(resultmin);
                    break;
                case "*":
                    double mul = f1 * f2;
                    string resultmul = String.Format("{0:c}", mul);
                    Console.WriteLine(resultmul);
                    break;
                case "/":
                    double del = f1 / f2;
                    string resultdel = String.Format("{0:c}", del);
                    Console.WriteLine(resultdel);
                    break;

                default:
                    Console.WriteLine("Введенно неверно"); 
                    break;
            }
        }
        static void Main(string[] args)
        {
            //Task1_1();
            //Task1_2();
            //Task1_3();
            Task2();
            Console.ReadKey();
        }
    }
}
    
    
        
