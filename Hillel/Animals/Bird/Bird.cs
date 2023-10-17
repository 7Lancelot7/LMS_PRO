namespace Animals.Bird;

public class Bird:Animal
{
    public sealed override void Move()
    {
        Console.WriteLine("Flying...");
    }

    public override void Speak()
    {
        Console.WriteLine("Tweeting...");
    }

    protected Bird()
    {
    }

    public Bird(string name, int age)
    {
        Name = name;
        Age = age;
    }
}