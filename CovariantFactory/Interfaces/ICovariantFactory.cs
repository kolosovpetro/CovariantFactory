namespace CovariantFactory.Interfaces
{
    public interface ICovariantFactory<out T>
    {
        T CreateInstance(string name, int age);
    }
}