using System;
using System.Linq;

namespace Program
{
    public class Program
    {
        public static string TenBase(int n, int resSys)
        {
            char[] symbols = {'0','1','2','3','4','5','6','7','8','9',
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P',
                'Q','R','S','T','U','V','W','X','Y','Z'};

            if (n < resSys)
            {
                return symbols[n].ToString();
            }

            return TenBase(n / resSys, resSys) + symbols[n % resSys];
        }

        public static int F(int n, int resSys, int level, ref int depth)
        {
            if (level > depth)
            {
                depth = level;
                Console.WriteLine("Рівень = " + level);
            }

            if (n > resSys)
            {
                return F(n / resSys, resSys,level + 1, ref depth);
            }

            return level;
        }

        static void Main()
        {
            int depth = 0;

            Console.Write("Число: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Система: ");
            int resSys = int.Parse(Console.ReadLine());

            string result = TenBase(number, resSys);
            Console.WriteLine("Результат: " + result);

            F(number, resSys, 1, ref depth);
            Console.WriteLine("Глибина = " + (depth + 1));
        }
    }
}