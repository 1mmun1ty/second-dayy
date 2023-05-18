using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                num += 5;
                Console.WriteLine("Вы ввели положительное число, добавим к нему 5");
            }    
            else
            {
                num -= 5;
                Console.WriteLine("Вы ввели отрицательное число, вычтим ещё 5");
            }
            Console.WriteLine(num   );
            Console.ReadKey();

            Console.WriteLine("Введите 1-ое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3-ое число:");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = a;

            if(max < b)
             {
                max = b;
            }
            if(max < c)
            {
                max = c;
            }
            Console.WriteLine($"Максимальное число из этих 3 цифр:{max}");
            Console.ReadKey();


            Console.WriteLine("Введите 1 - ое число: ");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 - ое число: ");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3 - ое число: ");
            int three = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (one > 0)
            {
                sum += one;
            }
            if (two > 0)
            {
                sum += two;
            }
            if (three > 0)
            {
                sum += three;
            }
            Console.WriteLine($"Сумма трёх положительных чисел{sum}");
            Console.ReadKey();
        }
    }
}
