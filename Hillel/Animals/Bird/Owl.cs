namespace Animals.Bird;

public class Owl:Bird
{
    
    public override void Speak()
    {
        Console.WriteLine("Hooting...");
    }

    public Owl(string name, int age)
    {
        Name = name;
        Age = age;
    }
}