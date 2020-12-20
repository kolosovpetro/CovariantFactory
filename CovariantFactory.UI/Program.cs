using CovariantFactory.Implementations;
using CovariantFactory.Interfaces;
using CovariantFactory.Models;

namespace CovariantFactory.UI
{
    public static class Program
    {
        private static void Main()
        {
            ICovariantFactory<IAnimal> dogFactory = new CovariantFactory<Dog>();
            var dog = dogFactory.CreateInstance("Sharik", 2);
            dog.SayName();
            dog.SayAge();
            
            ICovariantFactory<Dog> wolfFactory = new CovariantFactory<Wolf>();
            var wolf = wolfFactory.CreateInstance("Bamboo", 5);
            wolf.SayName();
            wolf.SayAge();
        }
    }
}