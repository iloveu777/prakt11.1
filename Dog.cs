using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt11._1
{
    internal class Dog
    {
        public string Breed { get; set; }
        public string Size { get; set; }
        public int Age { get; set; }
        public string Color {get; set; }
        public Dog(string breed, string size, int age, string color) 
        {
            Breed = breed;
            Size = size;
            Age = age;
            Color = color;

        }
        public void Eat()
        {
            Console.WriteLine($"{Breed} ест.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Breed} спит.");
        }

        public void Sit()
        {
            Console.WriteLine($"{Breed} сидит.");
        }

        public void Run()
        {
            Console.WriteLine($"{Breed} бежит.");
        }
    }
}
