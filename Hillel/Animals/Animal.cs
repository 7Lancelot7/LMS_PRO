namespace Animals;

public abstract class Animal
{
    private static int Id { get; set; }
    public string Name { get; protected set; }
    public int Age { get; protected set; }

    public virtual void Move()
    {
        Console.WriteLine("Moving...");
    }

    public virtual void Speak()
    {
        Console.WriteLine("Strange sounds");
    }
    //In my opinion is better to use abstract methods
    
    
    //public abstract void Move(); 
    //public abstract void Speak();

    protected Animal()
    {
        Id++;
    }

    protected Animal(string name, int age)
    {
        Id++;
        Name = name;
        Age = age;
    }
}