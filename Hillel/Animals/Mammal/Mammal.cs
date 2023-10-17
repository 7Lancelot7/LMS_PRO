namespace Animals.Mammal;

public class Mammal:Animal
{
    protected Mammal()
    {
    }

    public Mammal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override void Move()
    {
        Console.WriteLine("Running...");
    }

    public override void Speak()
    {
        Console.WriteLine("Screaming...");
    }
}