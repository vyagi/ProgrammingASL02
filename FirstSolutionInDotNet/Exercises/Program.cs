using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            // Console.WriteLine("Hello");

            //Task 2
            // var name = "Marcin";
            // Console.WriteLine(name);

            //Task 3
            // var name = "Marcin";
            // Console.Write("Hello ");
            // Console.WriteLine(name);
            //
            // Console.WriteLine("Hello " + name);
            //
            // Console.WriteLine(string.Format("Hello {0}", name));
            //
            // //USE THIS:
            // Console.WriteLine($"Hello {name}");

            //Task 4
            // Console.WriteLine("What's your name?");
            // var name = Console.ReadLine();
            // Console.WriteLine($"Hello {name}");

            //Task 5
            Console.WriteLine("Enter the radius of the circle");
            
            var radius = Convert.ToDouble(Console.ReadLine());
            
            var area = Math.PI * radius * radius;
            
            Console.WriteLine($"The area of the circle with radius {radius} is {area}");

            //Task 6, 7
            //Homework

            
        }
    }
}
