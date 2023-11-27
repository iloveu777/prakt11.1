using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace prakt11._1
{
    internal class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string SurName { get; set; }
       public Person(string firstname, string surname ,int age ) 
        
        {
            FirstName = firstname;
            Age = age;
            SurName = surname;         
        }
        public void Print()
        {
            WriteLine($"Имя - {FirstName}, фамилия - {SurName}, возраст - {Age}");
        }

    }
}
