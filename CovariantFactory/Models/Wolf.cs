using System;

namespace CovariantFactory.Models
{
    public class Wolf : Dog
    {
        public override void SayAge()
        {
            Console.WriteLine($"I'm a Wolf my age: {Age}");
        }

        public override void SayName()
        {
            Console.WriteLine($"I'm a Wolf, my name is: {Name}");
        }
    }
}