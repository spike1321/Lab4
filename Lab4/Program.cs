using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введиде целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    sum += 2 * i - 1;
                    Console.WriteLine($"Квадрат суммы {i} равен: {sum}");
                }
               
            }
            else
            {
                Console.WriteLine("Введенно число меньше 0");
            }


            Console.ReadKey();
        }
    }
}
