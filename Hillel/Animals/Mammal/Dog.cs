namespace Animals.Mammal;

public class Dog : Mammal
{
    public override void Move()
    {
        Console.WriteLine("Running after a stick ");
    }

    public override void Speak()
    {
        Console.WriteLine("Gav Gav...");
    }

    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }
}