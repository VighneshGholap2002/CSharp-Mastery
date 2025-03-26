// Method Overloading (Compile-time Polymorphism)
class MathOperations
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
}

class Program
{
    static void Main()
    {
        MathOperations m = new MathOperations();
        Console.WriteLine(m.Add(5, 10));     // Calls int version
        Console.WriteLine(m.Add(5.5, 10.5)); // Calls double version
    }
}


// Method Overriding (Runtime Polymorphism)
class Parent
{
    public virtual void Show() => Console.WriteLine("Parent Show");
}

class Child : Parent
{
    public override void Show() => Console.WriteLine("Child Show");
}

class Program
{
    static void Main()
    {
        Parent obj = new Child();
        obj.Show(); // Calls Child's Show() method
    }
}
