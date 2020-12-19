using System;
using CovariantFactory.Interfaces;

namespace CovariantFactory.Models
{
    public class Dog : IAnimal
    {
        public Dog()
        {
        }
        
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void SayAge()
        {
            Console.WriteLine($"I'm a Dog, my age: {Age}");
        }

        public virtual void SayName()
        {
            Console.WriteLine($"I'm a Dog, my name is: {Name}");
        }
    }
}