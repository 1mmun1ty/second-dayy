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
                Console.WriteLine("Выберите задание от 1 до 5:");
                Console.WriteLine("Напишите 10, чтобы узнать информацию о всех заданиях");
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

                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Некорректный выбор задания");
                        break;
                }

                Console.ReadKey();

            }
            }
        }
    }
