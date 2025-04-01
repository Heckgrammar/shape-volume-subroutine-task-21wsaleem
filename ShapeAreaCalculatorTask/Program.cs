using System;

namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle Area: " + AreaOfRectangle(7, 4));
            Console.WriteLine("Circle Area: " + AreaOfCircle(5));
            Console.WriteLine("Triangle Area: " + AreaOfTriangle(10, 8));
        }

        static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        static double AreaOfCircle(double radius)
        {
            return 3.14 * radius * radius;
        }

        static double AreaOfTriangle(double b, double h)
        {
            return 0.5 * b * h;
        }
    }
}
