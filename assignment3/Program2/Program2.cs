using System;
using System.Collections.Specialized;
using System.Formats.Asn1;

namespace assignment3
{
    public abstract class Shape //抽象类
    {
        abstract public double getArea();
        abstract public bool IsValid();
    }

    public class Rectangle : Shape
    {
        double area;
        double x, y; //长和宽
        bool isValid;
        public Rectangle(double X, double Y) { x = X; y = Y; isValid = true; }
        public override double getArea()
        {
            if (isValid)
            {
                area = x * y;
                return area;
            }
            else { return double.NaN; }
        }
        public override bool IsValid()
        {
            if (x <= 0 || y <= 0) { return isValid = false; }
            else { return isValid = true; }
        }
    }

    public class Square : Shape
    {
        double area;
        double m; //边长
        bool isValid;
        public Square(double M) { m = M; isValid = true; }
        public override double getArea()
        {
            if (isValid)
            {
                area = m * m;
                return area;
            }
            else { return double.NaN; }
        }
        public override bool IsValid()
        {
            if (m != 0) { return isValid = true; }
            else { return isValid = false; }
        }
    }

    public class Triangle : Shape
    {
        double area;
        double a, b, c; //三边
        bool isValid;
        public Triangle(double A, double B, double C) { a = A; b = B; c = C; isValid = true; }
        public override double getArea()
        {
            if (isValid)
            {
                double p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return area;
            }
            else { return double.NaN; }
        }
        public override bool IsValid()
        {
            if (a + b > c && a + c > b && b + c > a) { return isValid = true; }
            else { return isValid = false; }
        }
    }

    public class Circle : Shape
    {
        double area;
        double radius;
        bool isValid;
        public Circle(double r) { radius = r; }
        public override double getArea()
        {
            if(isValid) { return area = Math.PI * radius * radius; }
            else { return double.NaN; }
        }
        public override bool IsValid()
        {
            if (radius != 0) { return isValid = true; }
            else { return isValid = false; }
        }
    }

    class SimpleFactory
    {
        public Shape CreateShape(int Type, double a = 0, double b = 0, double c = 0)
        {
            switch(Type)
            {
                case 0: return new Circle(a);
                case 1: return new Square(a);
                case 2: return new Rectangle(a, b);
                case 3: return new Triangle(a, b, c);
                default:return null;
            }
        }
    }

    internal class Program2
    {
        static double area = 0;
        static SimpleFactory sFactory = new SimpleFactory();
        static Random rand = new Random();
        static double[] f = new double[3];
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int m = rand.Next(0, 3);
                if (m == 0) //Circle
                {
                    f[0] = rand.Next(10, 200) / 10.0;
                    Shape shape0 = sFactory.CreateShape(0, f[0]);
                    Console.WriteLine($"Circle: radius = {f[0]}");
                    shape0.IsValid();
                    area += shape0.getArea();
                }
                else if(m == 1) //Square
                {
                    f[0] = rand.Next(10, 200) / 10.0;
                    Shape shape1 = sFactory.CreateShape(1, f[0]);
                    Console.WriteLine($"Square: a = {f[0]}");
                    shape1.IsValid();
                    area += shape1.getArea();
                }
                else if (m == 2) //Rectangle
                {
                    f[0] = rand.Next(10, 200) / 10.0;
                    f[1] = rand.Next(10, 200) / 10.0;
                    Shape shape2 = sFactory.CreateShape(2, f[0], f[1]);
                    Console.WriteLine($"Reatangle: a = {f[0]}, b = {f[1]}");
                    shape2.IsValid();
                    area += shape2.getArea();
                }
                else if (m == 3) //Triangle
                {
                    f[0] = rand.Next(10, 200) / 10.0;
                    f[1] = rand.Next(10, 200) / 10.0;
                    f[2] = rand.Next(10, 200) / 10.0;
                    Shape shape3 = sFactory.CreateShape(3, f[0], f[1], f[2]);
                    Console.WriteLine($"Triangle: a = {f[0]}, b = {f[1]}, c = {f[2]}");
                    shape3.IsValid();
                    area += shape3.getArea();
                }
            }
            Console.WriteLine($"Area Sum:{area:F}");
        }

    }
}
