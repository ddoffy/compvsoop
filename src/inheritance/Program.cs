// See https://aka.ms/new-console-template for more information

var animals = new IAnimal[] { new Cat(), new Dog() };

foreach (var animal in animals)
{
    animal.Run();
    animal.Eat();
    animal.Sleep();
    animal.MakeSound();
    animal.Swimming();
}

interface IAnimal
{
    void Run();
    void Eat();
    void Sleep();
    void MakeSound();
    void Swimming();
    void Fly();
}

public abstract class Animal : IAnimal
{
    protected readonly string Name;

    protected Animal(string name)
    {
        Name = name;
    }

    public abstract void Run();

    public abstract void Eat();

    public abstract void Sleep();
    public abstract void MakeSound();

    public abstract void Swimming();
    public abstract void Fly();
}

public class Cat : Animal
{
    public Cat(string name = nameof(Cat)) : base(name)
    {
    }

    public override void Run()
    {
        Console.WriteLine($"{Name} is running");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} is making sound");
    }

    public override void Swimming()
    {
        Console.WriteLine($"{Name} is swimming");
    }

    public override void Fly()
    {
        Console.WriteLine($"{Name} is flying");
    }
}

public class Dog : Animal
{
    public Dog(string name = nameof(Dog)) : base(name)
    {
    }

    public override void Run()
    {
        Console.WriteLine($"{Name} is running");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} is making sound");
    }

    public override void Swimming()
    {
        Console.WriteLine($"{Name} is swimming");
    }

    public override void Fly()
    {
        Console.WriteLine($"{Name} is flying");
    }
}

//
// public interface IRunable
// {
//     void Run();
// }
//
// public interface IEatable
// {
//     void Eat();
// }
//
// public interface ISleepable
// {
//     void Sleep();
// }
//
// public interface IMakeSoundable
// {
//     void MakeSound();
// }
//
// public interface ISwimmable
// {
//     void Swimming();
// }
//
// public interface IFlyable
// {
//     void Fly();
// }
