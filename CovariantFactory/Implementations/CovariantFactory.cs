using CovariantFactory.Interfaces;

namespace CovariantFactory.Implementations
{
    public class CovariantFactory<T> : ICovariantFactory<T> where T : IAnimal, new()
    {
        public T CreateInstance(string name, int age)
        {
            var instance = new T {Age = age, Name = name};
            return instance;
        }
    }
}