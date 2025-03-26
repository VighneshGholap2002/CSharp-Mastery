
class Person
{
    private string name; // Private field

    public string Name  // Public property
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "John Doe";
        Console.WriteLine(p.Name);
    }
}
