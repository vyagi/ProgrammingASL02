using System;

namespace ObjectOrientedExercise
{
    class Point
    {
        private double _x;   
        private double _y;

        public double X => _x;
        public double Y => _y;

        public Point() : this(1,1) { }

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double Distance() => 
            Math.Sqrt(X * X + Y * Y);

        public double Distance(Point another) => 
            Math.Sqrt(Math.Pow(another.X - X, 2) + Math.Pow(another.Y - Y, 2));

        public static double Distance(Point first, Point second) => 
            first.Distance(second);

        public override string ToString() => $"({X},{Y})";

        public enum ReflectionType
        {
            X,
            Y,
            Origin
        }

        public Point Reflect(ReflectionType reflectionType)
        {
            switch (reflectionType)
            {
                case ReflectionType.X:
                    return new Point(X, -Y);
                case ReflectionType.Y:
                    return new Point(-X, Y);
                case ReflectionType.Origin:
                    return new Point(-X, -Y);
                default:
                    throw new Exception("Invalid choice");
            }
        }
    }
    
    class Program
    {
        public enum Conversion
        {
            FromCelsiusToFahrenheit,
            FromFahrenheitToCelsius,
            FromKelvinToCelsius,
            //so on
        }
        
        public static double ConvertTemperature(double temperature, Conversion type)
        {
            switch (type)
            {
                case Conversion.FromCelsiusToFahrenheit:
                    return temperature * 1.8 + 32;
                case Conversion.FromFahrenheitToCelsius:
                    return (temperature - 32) / 1.8;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertTemperature(212, Conversion.FromFahrenheitToCelsius));
            Console.WriteLine(ConvertTemperature(0, Conversion.FromCelsiusToFahrenheit));
            
            var p = new Point(-3, 7);
            Console.WriteLine(p.ToString());

            Console.WriteLine(new Point(0,0).ToString());

            Console.WriteLine(p.Reflect(Point.ReflectionType.Origin));
            Console.WriteLine(p.Reflect(Point.ReflectionType.X));
            Console.WriteLine(p.Reflect(Point.ReflectionType.Y));

            // Console.WriteLine(p.X);
            //
            // var p1 = new Point();
            // Console.WriteLine(p1.Distance());
            //
            // var p2 = new Point(3, 4);
            // Console.WriteLine(p2.Distance());
            //
            // Console.WriteLine(p1.Distance(p));
            // Console.WriteLine(p1.Distance(p1));
            //
            // Console.WriteLine(Point.Distance(p, p));
            // Console.WriteLine(Point.Distance(new Point(1,1), new Point(4,5)));

        }
    }
}
