# Covariant Factory

Simple snippet to show the use of covariance in C#.

## Example

```cs
ICovariantFactory<IAnimal> dogFactory = new CovariantFactory<Dog>();
var dog = dogFactory.CreateInstance("Sharik", 2);
dog.SayName();
dog.SayAge();
            
ICovariantFactory<Dog> wolfFactory = new CovariantFactory<Wolf>();
var wolf = wolfFactory.CreateInstance("Bamboo", 5);
wolf.SayName();
wolf.SayAge();
```