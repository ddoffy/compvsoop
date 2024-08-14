// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var animals = new IAnimal[]
{
    new Animal("Cat", new AbleToRun(), new AbleToEat(), new AbleToSleep(), new AbleToMakeSound(), new AbleToSwim(), new UnableToFly()),
    new Animal("Dog", new AbleToRun(), new AbleToEat(), new AbleToSleep(), new AbleToMakeSound(), new AbleToSwim(), new UnableToFly()),
    new Animal("Horse", new AbleToRun(), new AbleToEat(), new UnableToSleep(), new AbleToMakeSound(), new AbleToSwim(), new UnableToFly()),
    new Animal("Dolphin", new UnableToRun(), new AbleToEat(), new AbleToSleep(), new AbleToMakeSound(), new AbleToSwim(), new UnableToFly()),
    new Animal("Eagle", new UnableToRun(), new AbleToEat(), new UnableToSleep(), new AbleToMakeSound(), new UnableToSwim(), new AbleToFly())
};

foreach (var animal in animals)
{
    animal.Run();
    animal.Eat();
    animal.Sleep();
    animal.MakeSound();
    animal.Swimming();
    animal.Fly();
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

public interface IRunable
{
    void Run(string name);
}

public class UnableToRun : IRunable
{
    public void Run(string name)
    {
        Console.WriteLine($"{name} is unable to run");
    }
}

public class AbleToRun : IRunable
{
    public void Run(string name)
    {
        Console.WriteLine($"{name} is running");
    }
}

public interface IEatable
{
    void Eat(string name);
}

public class UnableToEat : IEatable
{
    public void Eat(string name)
    {
        Console.WriteLine($"{name} is unable to eat");
    }
}

public class AbleToEat : IEatable
{
    public void Eat(string name)
    {
        Console.WriteLine($"{name} is eating");
    }
}

public interface ISleepable
{
    void Sleep(string name);
}

public class UnableToSleep : ISleepable
{
    public void Sleep(string name)
    {
        Console.WriteLine($"{name} is unable to sleep");
    }
}

public class AbleToSleep : ISleepable
{
    public void Sleep(string name)
    {
        Console.WriteLine($"{name} is sleeping");
    }
}

public interface IMakeSoundable
{
    void MakeSound(string name);
}

public class UnableToMakeSound : IMakeSoundable
{
    public void MakeSound(string name)
    {
        Console.WriteLine($"{name} is unable to make sound");
    }
}

public class AbleToMakeSound : IMakeSoundable
{
    public void MakeSound(string name)
    {
        Console.WriteLine($"{name} is making sound");
    }
}

public interface ISwimmable
{
    void Swimming(string name);
}

public class UnableToSwim : ISwimmable
{
    public void Swimming(string name)
    {
        Console.WriteLine($"{name} is unable to swim");
    }
}

public class AbleToSwim : ISwimmable
{
    public void Swimming(string name)
    {
        Console.WriteLine($"{name} is swimming");
    }
}

public interface IFlyable
{
    void Fly(string name);
}

public class UnableToFly : IFlyable
{
    public void Fly(string name)
    {
        Console.WriteLine($"{name} is unable to fly");
    }
}

public class AbleToFly : IFlyable
{
    public void Fly(string name)
    {
        Console.WriteLine($"{name} is flying");
    }
}

// implement the IAnimal interface using composition
public class Animal : IAnimal
{
    private string _name;
    private readonly IRunable _run;
    private readonly IEatable _eat;
    private readonly ISleepable _sleep;
    private readonly IMakeSoundable _makeSound;
    private readonly ISwimmable _swim;
    private readonly IFlyable _fly;

    public Animal(string name, IRunable run, IEatable eat, ISleepable sleep, IMakeSoundable makeSound, ISwimmable swim, IFlyable fly)
    {
        _name = name;
        _run = run;
        _eat = eat;
        _sleep = sleep;
        _makeSound = makeSound;
        _swim = swim;
        _fly = fly;
    }

    public void Run() => _run.Run(_name);
    public void Eat() => _eat.Eat(_name);
    public void Sleep() => _sleep.Sleep(_name);
    public void MakeSound() => _makeSound.MakeSound(_name);
    public void Swimming() => _swim.Swimming(_name);
    public void Fly() => _fly.Fly(_name);
}