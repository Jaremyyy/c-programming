using System;

public interface ISwimmable
{
    void Swim()
    {
        Console.WriteLine("I can swim!");
    }
}
public interface IFlyable
{
    int MaxHeight { get => 0; }
    void Fly()
    {
        Console.WriteLine($"I can fly at {MaxHeight} meters height!");
    }
}
public interface IRunnable
{
    int MaxSpeed { get => 0; }
    void Run()
    {
        Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
    }
}
public interface IAnimal
{
    int LifeDuration { get => 0; }
    void Voice()
    {
        Console.WriteLine("No voice!");
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"I am a {GetType().Name} and I live approximately {LifeDuration} years.");
    }
}
public class Cat : IAnimal, IRunnable
{
    public int LifeDuration { get; } = 20;
    public void Voice()
    {
        Console.WriteLine("Meow!");
    }
    int MaxSpeed { get; } = 15;
    public void Run()
    {
        Console.WriteLine($"Cat can run up to {MaxSpeed} kilometers per hour!");
    }
}
public class Eagle : IAnimal, IFlyable
{
    public int LifeDuration { get; } = 25;
    public int MaxHeight { get; } = 4500;
}
public class Shark : IAnimal, ISwimmable
{
    public int LifeDuration { get; } = 30;

    public void Voice()
    {
        Console.WriteLine("No voice!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IAnimal cat = new Cat();
        cat.Voice();
        cat.ShowInfo();
        ((IRunnable)cat).Run();

        Console.WriteLine();

        IAnimal eagle = new Eagle();
        eagle.ShowInfo();
        eagle.Voice();
        ((IFlyable)eagle).Fly();

        Console.WriteLine();

        IAnimal shark = new Shark();
        shark.ShowInfo();
        shark.Voice();
        ((ISwimmable)shark).Swim();
    }
}
