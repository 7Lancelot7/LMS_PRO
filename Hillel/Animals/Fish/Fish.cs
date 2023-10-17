namespace Animals.Fish;

public class Fish:Animal
{
    protected Fish()
    {
    }

    public Fish(string name, int age) : base(name, age)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Swimming...");
    }

    public sealed override void Speak()
    {
        Console.WriteLine("bubble bubble...");
    }
}