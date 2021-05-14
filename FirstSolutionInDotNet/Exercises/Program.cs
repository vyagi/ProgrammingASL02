using System;
using System.Collections.Generic;

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
            // Console.WriteLine("Enter the radius of the circle");
            //
            // var radius = Convert.ToDouble(Console.ReadLine());
            //
            // var area = Math.PI * radius * radius;
            //
            // Console.WriteLine($"The area of the circle with radius {radius} is {area}");

            //Task 8
            // Console.WriteLine("Enter the length of the first side");
            // var a = Convert.ToDouble(Console.ReadLine());
            //
            // Console.WriteLine("Enter the length of the second side");
            // var b = Convert.ToDouble(Console.ReadLine());
            //
            // Console.WriteLine("Enter the length of the third side");
            // var c = Convert.ToDouble(Console.ReadLine());
            //
            // var perimeter = a + b + c;
            // var s = perimeter / 2;
            // var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            //
            // Console.WriteLine($"The area is {area} and the perimeter is {perimeter}");

            //Task 9a)
            // Console.WriteLine("Enter the first number");
            // var n1 = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("Enter the second number");
            // var n2 = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("Enter the third number");
            // var n3 = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("Enter the fourth number");
            // var n4 = Convert.ToInt32(Console.ReadLine());
            //
            // var sum = n1 + n2 + n3 + n4;
            // var average = sum / 4.0;
            //
            // Console.WriteLine($"The sum is {sum} and the average is {average}");

            //Task 9b)

            // var array = new int[4];
            // for (var i = 0; i < array.Length; i++)
            // {
            //     Console.WriteLine($"Enter the number {i+1}");
            //     array[i] = Convert.ToInt32(Console.ReadLine());
            // }
            //
            // var sum = 0;
            // foreach (var element in array)
            // {
            //     sum += element;
            // }
            //
            // var average = 1.0 * sum / array.Length;
            // Console.WriteLine($"The sum is {sum} and the average is {average}");

            //Task 9c)
            var list = new List<int>();
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter the number {i+1}");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var sum = 0;
            foreach (var element in list)
            {
                sum += element;
            }
            var average = 1.0 * sum / list.Count;
            Console.WriteLine($"The sum is {sum} and the average is {average}");
            
            
            //Task 6, 7, 9
            //Homework
        }
    }
}
