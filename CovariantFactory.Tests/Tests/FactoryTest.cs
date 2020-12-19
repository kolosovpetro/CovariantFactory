using CovariantFactory.Implementations;
using CovariantFactory.Interfaces;
using CovariantFactory.Models;
using FluentAssertions;
using NUnit.Framework;

namespace CovariantFactory.Tests.Tests
{
    public class Tests
    {
        [Test]
        public void Dog_Factory_Test()
        {
            ICovariantFactory<IAnimal> factory = new CovariantFactory<Dog>();
            var dog = factory.CreateInstance("Sharik", 2);
            (dog is Dog).Should().BeTrue();
            dog.GetType().Should().Be(typeof(Dog));
            dog.Name.Should().Be("Sharik");
            dog.Age.Should().Be(2);
        }

        [Test]
        public void Wolf_Factory_Test()
        {
            ICovariantFactory<IAnimal> factory = new CovariantFactory<Wolf>();
            var wolf = factory.CreateInstance("Kram", 5);
            (wolf is Wolf).Should().BeTrue();
            wolf.GetType().Should().Be(typeof(Wolf));
            wolf.Name.Should().Be("Kram");
            wolf.Age.Should().Be(5);
        }
    }
}