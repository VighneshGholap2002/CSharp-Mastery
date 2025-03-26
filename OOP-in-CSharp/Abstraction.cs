// Abstract Class Example
abstract class Vehicle
{
    public abstract void Start(); // Abstract method (must be implemented)
}

class Car : Vehicle
{
    public override void Start() => Console.WriteLine("Car is starting...");
}

class Program
{
    static void Main()
    {
        Vehicle myCar = new Car();
        myCar.Start();
    }
}


// Interface Example
interface IAnimal
{
    void MakeSound();
}

class Dog : IAnimal
{
    public void MakeSound() => Console.WriteLine("Dog barks!");
}

class Program
{
    static void Main()
    {
        IAnimal myDog = new Dog();
        myDog.MakeSound();
    }
}
