using System;

namespace InterfacesIntro
{
    public interface IShape
    {
        double Area();
    }

    public interface ICreature
    {
        void Breathe();
    }

    public abstract class Shape : IShape, ICreature
    {
        public double Area()
        {
            return 0;
        }

        public void Breathe()
        {
            throw new NotImplementedException();
        }
    }

    public class LivingSquare : IShape, ICreature
    {
        public double Area() => 10;

        public void Breathe()
        {
            Console.WriteLine("Breathing !!!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var ls = new LivingSquare();
            Console.WriteLine(ls.Area());
            ls.Breathe();
        }
    }
}
