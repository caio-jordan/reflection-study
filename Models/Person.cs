using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reflection_study.Models
{
    public class Person
    {
        public string Name { get; set; }
        private int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }

        private void ShowAge()
        {
            Console.WriteLine($"I am {Age} years old.");
        }
    }

}