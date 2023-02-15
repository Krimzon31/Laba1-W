using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_W
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S = 0;
            Console.WriteLine("Введите n ");
            int n = Convert.ToInt32(Console.ReadLine());
            // проверка отрицательности n
            if (n < 0)
            {
                Console.WriteLine("n должен быть положительным");
            }
            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            for (var j = 0; j <= n; j++)
            {
                double e = ((-1) ^ n) * ((x) ^ 2 * n) / (getFactorial(n));
                S = S + e;
            }
            Console.WriteLine($"Ответ: {S}");
        }
        //Считает факториал
        public static int getFactorial(int f)
        {
            int result = 1;
            for (int i = 1; i <= f; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
