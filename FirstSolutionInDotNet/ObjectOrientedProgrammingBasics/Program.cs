using System;

namespace ObjectOrientedProgrammingBasics
{
    class Person
    {
        private int _weight;

        private int _height;

        private string _name;

        public int Weight
        {
            get => _weight;
            set
            {
                if (value <= 0) throw new Exception("Weight must be positive");

                _weight = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("Name must be valid");

                _name = value;
            }
        }

        public int Height => _height;

        public Person(string name, int weight, int height)
        {
            if (weight <= 0) throw new Exception("Weight must be positive");

            if (height <= 0) throw new Exception("Height must be positive");

            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name must be valid");

            _name = name;
            _weight = weight;
            _height = height;
        }

        public double Bmi() => 10000.0 * _weight / (_height * _height);
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("Marcin", 100, 180);

            Console.WriteLine($"{p1.Name} has {p1.Bmi()}");

            p1.Name = "Antonio";
            p1.Weight = 80;

            Console.WriteLine($"{p1.Name} has {p1.Bmi()} and he is {p1.Height} tall");
        }
    }
}
