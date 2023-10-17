namespace Animals.Fish;

public class Shark:Fish
{
    public override void Move()
    {
        Console.WriteLine("Hunting...");
    }

    public Shark(string name, int age) : base(name, age)
    {
    }
}