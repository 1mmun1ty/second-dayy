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
            {
                while (true)
                {
                    Console.WriteLine("Напишите 10, чтобы узнать информацию о всех заданиях");
                    int number_mission = Convert.ToInt32(Console.ReadLine());
                    switch (number_mission)
                    {
                        case 10:
                            Console.WriteLine("1-е задание: Число +-5");
                            Console.WriteLine("2-е задание: Макс число из 3");
                            Console.WriteLine("3-е задание: Сумма только положительных чисел");
                            Console.WriteLine("4-е задание: Удвоить x, если x больше 10");
                            Console.WriteLine("5-е задание: День недели в зависимости от числа");
                            Console.WriteLine("6-е задание: Минимальное число большее 200 и делится на 17");
                            Console.WriteLine("7-е задание: 20км на какой день и 100км");
                            Console.WriteLine("8-е задание: Факториал");
                            Console.WriteLine("9-е задание: Натуральное число и его наименьший делитель отличный от 1");

                            break;
                    }
                    Console.WriteLine("Выберите задание от 1 до 9:");
                    int mission = Convert.ToInt32(Console.ReadLine());
                    switch (mission)
                    {
                        case 1:
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
                            Console.WriteLine(num);
                            Console.WriteLine("Нажмите ENTER для выхода в главное меню");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.WriteLine("Введите 1-ое число:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите 2-ое число:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите 3-ое число:");
                            int c = Convert.ToInt32(Console.ReadLine());

                            int max = a;

                            if (max < b)
                            {
                                max = b;
                            }
                            if (max < c)
                            {
                                max = c;
                            }
                            Console.WriteLine($"Максимальное число из этих 3 цифр: {max}");
                            Console.WriteLine("Нажмите ENTER для выхода в главное меню");
                            Console.ReadKey();
                            break;

                        case 3:
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
                            Console.WriteLine($"Сумма трёх положительных чисел {sum}");
                            Console.WriteLine("Нажмите ENTER для выхода в главное меню");
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.WriteLine("Введите число: ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            if (x > 10)
                            {
                                x *= 2;
                                Console.WriteLine($"Введенное число больше 10, умножим его на 2: {x}");
                            }
                            else if (x < 10)
                            {
                                Console.WriteLine("Введеное число меньше 10, не изменяем его");
                            }
                            Console.WriteLine("Нажмите ENTER для выхода в главное меню");
                            break;

                        case 5:
                            Console.WriteLine("Введите число от 1 до 7:");

                            int day = Convert.ToInt32(Console.ReadLine());

                            switch (day)
                            {
                                case 1:
                                    Console.WriteLine("Понедельник");
                                    break;

                                case 2:
                                    Console.WriteLine("Вторник");
                                    break;

                                case 3:
                                    Console.WriteLine("Среда");
                                    break;

                                case 4:
                                    Console.WriteLine("Четверг");
                                    break;

                                case 5:
                                    Console.WriteLine("Пятница");
                                    break;

                                case 6:
                                    Console.WriteLine("Суббота");
                                    break;

                                case 7:
                                    Console.WriteLine("Воскресенье");
                                    break;

                                default:
                                    Console.WriteLine("Некорректное число, введите число от 1 до 7");
                                    break;
                            }
                            Console.WriteLine("Нажмите ENTER для выхода в главное меню");
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine("Некорректный выбор задания");
                            break;

                        case 6:
                            Console.WriteLine("Вывести в консоль минимальное число больше 200 и которое делится нацело на 17");
                            int chislo = 200;
                            int delenie = 17;
                            while (true)
                            {
                                if (chislo % delenie == 0)
                                    break;
                                ++chislo;
                            }
                            Console.WriteLine(chislo);
                            Console.WriteLine("Нажмите ENTER для выхода в главное меню");
                            break;

                        case 7:
                            double distance = 10;
                            double final = 20;
                            int schetchik = 1;
                            double dlinnoe = 10;
                            distance *= 1.05;
                            while (distance < final)
                            {
                                distance += distance *= 0.05;
                                schetchik++;
                            }
                            while (dlinnoe >= 100)
                            {
                                dlinnoe += distance;

                            }
                            Console.WriteLine($"Человек пробежит {final} км на {schetchik}-й день ");
                            Console.WriteLine($"Пробежит 100км на {dlinnoe}-й день ");
                            Console.WriteLine("Нажмите ENTER для выхода в главное меню");
                            break;

                        case 8:
                            Console.WriteLine("Введите число которое хотите возвести в факториал");
                            int n = int.Parse(Console.ReadLine());
                            int factorial = 1;
                            for (int i = 1; i <= n; i++)
                            {
                                factorial = factorial * i;
                            }
                            Console.WriteLine($"Факториал {n} это {factorial}");
                            Console.ReadLine();
                            Console.WriteLine("Нажмите ENTER для выхода в главное меню");
                            break;

                        case 9:
                            Console.WriteLine("Ввести натуральное число");
                            int natural_number = int.Parse(Console.ReadLine());
                            int minimal_delitel = 0;
                            for (int i = 2; i <= natural_number; i++)
                            {
                                if (natural_number % i == 0)
                                {
                                    minimal_delitel = i;
                                    break;
                                }
                            }
                            Console.WriteLine($"Наименьший делитель числа {natural_number} отличный от 1 равен {minimal_delitel}");
                            Console.WriteLine("Нажмите ENTER для выхода в главное меню");
                            break;


                    }


                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
    }
}
