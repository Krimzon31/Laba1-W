using System;

namespace Laba1_W
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S = 0;
            Console.WriteLine("Введите n ");
            double n = Convert.ToDouble(Console.ReadLine());
            // проверка отрицательности n
            if (n < 0)
            {
                Console.WriteLine("n должен быть положительным");
            }
            else
            {
                Console.WriteLine("Введите x");
                double x = Convert.ToDouble(Console.ReadLine());
                for (int j = 0; j <= n; j++)
                {
                    double e = (Math.Pow((-1), n) * (Math.Pow(x, 2) * n)) / (getFactorial(n));
                    S = S + e;
                }
                Console.WriteLine($"Ответ: {S}");
            }
        }
        //Считает факториал
        public static int getFactorial(double f)
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
