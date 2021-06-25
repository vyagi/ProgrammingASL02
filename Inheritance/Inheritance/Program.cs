using System;

namespace Inheritance
{
    abstract class Shape
    {
        public abstract double Area();

        public abstract double Perimeter();
    }

    class Rectangle : Shape
    {
        private readonly double _a;
        private readonly double _b;

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double Area() => _a * _b;
        public override double Perimeter() => 2*( _a + _b );
    }

    class Triangle : Shape 
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override double Area()
        {
            var s = Perimeter() / 2;
            return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
        }

        public override double Perimeter() => _a + _b + _c;
    }

    public abstract class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Unspecified Sound");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meaow");
        }
    }

    public class Dog : Animal { }

    class Program
    {
        static void Main(string[] args)
        {
            // Shape shape = new Shape();
            // var area = shape.Area();
            // var perimeter = shape.Perimeter();

            // Console.WriteLine($"{area} and {perimeter}");

            Rectangle rectangle = new Rectangle(10, 5);
            var areaOfRectangle = rectangle.Area();
            var perimeterOfRectangle = rectangle.Perimeter();
            Console.WriteLine($"{areaOfRectangle} and {perimeterOfRectangle}");

            Triangle triangle = new Triangle(3, 4, 5);
            var areaOfTriangle = triangle.Area();
            var perimeterOfTriangle = triangle.Perimeter();
            Console.WriteLine($"{areaOfTriangle} and {perimeterOfTriangle}");

            Shape[] arrayOfShapes = new Shape[3];
            arrayOfShapes[0] = new Rectangle(4, 5);
            arrayOfShapes[1] = new Triangle(12,14,15);
            arrayOfShapes[2] = new Rectangle(10,10);

            foreach (Shape sh in arrayOfShapes)
            {
                Console.WriteLine(sh.GetType());
                
                Console.WriteLine($"{sh.Area()} and {sh.Perimeter()}");
            }

            Animal c = new Cat();
            c.MakeSound();

            Animal d = new Dog();
            d.MakeSound();
        }
    }
}
