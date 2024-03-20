using System;

namespace assignment2
{
    internal class Program2
    {
        public static int max = 0, min = 0;
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] values = s.Split(' '); //用空格分隔
            int[] num = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                num[i] = Convert.ToInt32(values[i]);
            }
            min = num[0];
            max = num[0];
            int Sum = Find(num);
            Console.WriteLine($"Max:{max}");
            Console.WriteLine($"Min:{min}");
            Console.WriteLine($"Sum:{Sum}");
            double aver = (double)Sum / num.Length;
            Console.WriteLine($"Average:{aver}");
            Console.ReadKey();
        }

        public static int Find(int[] number)
        {
            int sum = 0;
            foreach (int n in number)
            {
                if (n > max) { max = n; }
                if (n < min) { min = n; }
                sum += n;
            }
            return sum;
        }
    }
}