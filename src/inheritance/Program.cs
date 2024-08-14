// See https://aka.ms/new-console-template for more information

var animals = new IAnimal[] { new Cat(), new Dog() };

foreach (var animal in animals)
{
    animal.Run();
    animal.Eat();
    animal.Sleep();
}

interface IAnimal
{
    void Run();
    void Eat();
    void Sleep();
}

public class Cat : IAnimal
{
    public void Run()
    {
        Console.WriteLine("Cat is running");
    }

    public void Eat()
    {
        Console.WriteLine("Cat is eating");
    }

    public void Sleep()
    {
        Console.WriteLine("Cat is sleeping");
    }
}

public class Dog : IAnimal
{
    public void Run()
    {
        Console.WriteLine("Dog is running");
    }

    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }

    public void Sleep()
    {
        Console.WriteLine("Dog is sleeping");
    }
}