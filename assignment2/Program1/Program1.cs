using System;

namespace assignment2
{
    internal class Program1
    {
        public static int[] factor = new int[1000]; //存储素数因子
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int num = Convert.ToInt32(s);

            int m = PrimeNumberFactor(num);
           
            for(int i = 0; factor[i] != 0 ; i++)
            {
                Console.Write($"{factor[i]} ");
            }
            Console.Write($"{m}");
        }

        public static int PrimeNumberFactor(int number)
        {
            int j = 0;
            for (int i = 2; i * i <= number; )
            {
                if (number % i == 0)
                {
                    number = number / i;
                    factor[j] = i;
                    j++;
                }
                else i++;
            }
            return number;
        }
    }
}
