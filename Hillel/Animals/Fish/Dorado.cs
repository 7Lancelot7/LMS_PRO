namespace Animals.Fish;

public class Dorado:Fish
{
    public override void Move()
    {
        Console.WriteLine("Just swimming...");

    }

    public Dorado(string name, int age) : base(name, age)
    {
    }
}