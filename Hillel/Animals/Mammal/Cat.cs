namespace Animals.Mammal;

public class Cat : Mammal
{
    public override void Move()
    {
        Console.WriteLine("Climbing a tree...");
    }

    public override void Speak()
    {
        Console.WriteLine("Mayyy...");
    }

    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }
}