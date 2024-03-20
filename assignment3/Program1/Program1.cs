using System;

namespace assignment3
{
    public interface IsShape //接口
    {
        double getArea(); //面积
        bool IsValid(); //形状是否合法
    }

    public abstract class Shape : IsShape //抽象类
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

    internal class Program1
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(6, 10);
            Console.WriteLine($"Is Valid: {rectangle.IsValid()}");
            Console.WriteLine($"Area of Rectangle: {rectangle.getArea()}");

            Square square = new Square(3);
            Console.WriteLine($"Is Valid: {square.IsValid()}");
            Console.WriteLine($"Area of Square: {square.getArea()}");

            Triangle triangle = new Triangle(1, 3, 3);
            Console.WriteLine($"Is Valid: {triangle.IsValid()}");
            Console.WriteLine($"Area of Triangle: {triangle.getArea():F}");
        }
    }
}
