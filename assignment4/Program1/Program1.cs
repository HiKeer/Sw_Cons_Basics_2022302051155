using System;

namespace assignment4
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = tail.Next;
            }
        }

        public void ForEach(Action<T> action)
        {
            for(Node<T> n = head; n!= null; n = n.Next  ) 
            {
                action(n.Data);
            }
        }

    }


    internal class Program1
    {
        public static void Main(string[] args) 
        {
            Random random = new Random();
            GenericList<double> list = new GenericList<double>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(random.Next(1,1000)/10.0); //生成0.1~100的随机数
            }

            list.ForEach(a => Console.WriteLine(a));

            double min = 100;
            double max = 0;
            double sum = 0;
            list.ForEach(a =>
            {
                if (a < min) min = a;
                if (a > max) max = a;
                sum += a;
            });
            Console.WriteLine($"min={min}, max={max}, sum={sum:F}");

        }
    }
}