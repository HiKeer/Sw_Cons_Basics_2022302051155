using System;

namespace assignment2
{
    internal class Program4
    {
        public const int M = 3;
        public const int N = 4;
        static void Main(string[] args)
        {
            int[,] matrix = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string s = Console.ReadLine();
                string[] value = s.Split(' '); //用空格分隔
                for (int j = 0; j < value.Length; j++)
                {
                    matrix[i, j] = Convert.ToInt32(value[j]);
                }
            }

            if (IsToplitzMatrix(matrix)) { Console.WriteLine("True"); }
            else { Console.WriteLine("False"); }
        }

        public static bool IsToplitzMatrix(int[,] matrix)
        {
            int temp = 0;
            for (int j = 0, x = 0; j < N-1; j++)
            {
                x = j;
                for (int i = 0; x < M && i < N; i++, x++)
                {
                    if (i == 0 || x == 0) { temp = matrix[x, i]; }
                    if (matrix[x, i] != temp) { return false; }
                }
            }
            for (int j = 0, y = 0; j < N - 1; j++)
            {
                y = j;
                for (int i = 0; i < M && y < N; i++, y++)
                {
                    if (i == 0 || y == 0) { temp = matrix[i, y]; }
                    if (matrix[i, y] != temp) { return false; }
                }
            }
            return true;
        }
    }
}