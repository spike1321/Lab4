using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Введите А: ");

            if (int.TryParse(Console.ReadLine(), out a) && a >0)
            {

                Console.Write("Введите B: ");
                if (int.TryParse(Console.ReadLine(), out b) && b > 0)
                {

                    Console.Write("Введите C: ");
                    if (int.TryParse(Console.ReadLine(), out c) && c > 0)
                    {

                        int k = 0;
                        int n = 0;
                        int count = 0;
                        int i = 0;

                        while (a >= c)
                       
                        {
                            a -= c;
                            k++;
                        }
                        while (b >= c)
                        {
                            b -= c;
                            n++;
                        }
                        while (i < k)
                        {
                            count += n;
                            i++;
                        }
                        Console.WriteLine("Кол-во квадратов на прямоугольнике равно: {0}", count);
                    }
                    else
                    {
                        Console.WriteLine("Введенно некорректное или отрицательное значение!");
                    }
                }
                else
                {
                    Console.WriteLine("Введенно некорректное или отрицательное значение!");
                }
            }
            else
            {
                Console.WriteLine("Введенно некорректное или отрицательное значение!");
            }
            Console.ReadKey();
        }
    }
}
