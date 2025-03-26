class Animal  
{
    public void Speak() => Console.WriteLine("Animal speaks!");
}

class Dog : Animal  
{
    public void Bark() => Console.WriteLine("Dog barks!");
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Speak();  // Inherited method
        d.Bark();   // Own method
    }
}
