using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int positive = 0;
            int negative = 0;
            int number;
            int c = 0;
            do
            {
                Console.WriteLine("Введите положительные или отрицательные целые числа: ");

                if (int.TryParse(Console.ReadLine(), out number))
                {
                    c += 1;
                }
                else
                {
                    Console.WriteLine("Введены некорректные данные!");
                    c = 0;
                }

                if (number > 0)
                {
                    positive += 1;
                }
                else
                {
                    if (number < 0)
                    {
                        negative += 1;
                    }
                }
            }
            while (number != 0);
                if (positive > negative && c>0)
                {
                    Console.WriteLine("Количество положительных {0} больше отрицательных {1}", positive, negative);
                }
                else
                {
                    if (negative > positive && c > 0)
                    {
                        Console.WriteLine("Количество отрицательных {0} больше положительных {1}", negative, positive);
                    }
                    else if (negative == positive && c > 0)
                    {
                        Console.WriteLine("Количество отрицательных {0} и положительных {1} одинаково", negative, positive);
                    }
                }

                Console.ReadKey();
            }
        }
    }

