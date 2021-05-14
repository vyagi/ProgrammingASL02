using System;
using System.Collections.Generic;
using FirstClassLibrary;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args) //entry point
        {
           
        }

        static int Dummy()
        {
            return 4;
        }

        static void Method1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine(Dummy());

            var a = 10;
            var b = 450.1;
            var c = 44.2f;
            var d = 10.5M;
            var e = "Marcin";
            var f = DateTime.Now;

            Console.WriteLine(f.DayOfWeek);

            int[] arr = new[] { 1, 2, 3, 6 };

            foreach (var t in arr)
            {
                Console.WriteLine(t);
            }

            var flag = 1 < -5;

            if (flag)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
