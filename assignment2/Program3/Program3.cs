using System;

namespace assignment2
{
    internal class Program3
    {
        public static bool[] IsPrime = new bool[99]; //是否为素数
        static void Main(string[] args)
        {
            for (int i = 0; i < 99; i++) { IsPrime[i] = true; }

            ESieveMethod();

            for (int m = 0; m < 99; m++)
            {
                if (IsPrime[m] == true) { Console.Write($"{m + 2} "); }
            }
        }

        public static void ESieveMethod() //数组中i的倍数置0
        {
            for (int i = 2; i <= 10; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (j % i == 0 && j / i != 1) { IsPrime[j - 2] = false; }
                }
            }
        }
    }
}
