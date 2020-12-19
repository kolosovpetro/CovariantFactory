namespace CovariantFactory.Interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        void SayAge();
        void SayName();
    }
}