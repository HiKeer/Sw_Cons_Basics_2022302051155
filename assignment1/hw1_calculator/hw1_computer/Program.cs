using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_computer
{
    internal class Program
    {
        public static char c = ' ';
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            a = ReadDouble();
            b = ReadDouble();
            if (c == '+') Console.WriteLine($"{a + b}");
            if (c == '-') Console.WriteLine($"{a - b}");
            if (c == '*') Console.WriteLine($"{a * b}");
            if (c == '/') Console.WriteLine($"{a / b}");
            Console.ReadKey();
        }
        public static double ReadDouble()
        {
            double number = 0;
            int point = 0; //是否出现小数点
            int pointnum = 0;
            for (; ; )
            {
                int j = Console.Read();
                if (j == 46)
                {
                    point = 1;
                    continue;
                }//出现小数点
                if (point == 0 && j >= 48 && j <= 58)
                {
                    number = number * 10 + (j - 48);
                }
                else if (point == 1 && j >= 48 && j <= 58)
                {
                    pointnum--;
                    number += (j - 48) * Math.Pow(10, pointnum);
                }
                else if (j != '\r')
                {
                    c = (char)j;
                    break;
                }
                else break;
            }
            return number;
        }
    }
}
