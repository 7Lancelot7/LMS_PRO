namespace Animals.Bird;

public class Eagle:Bird
{
    
    public override void Speak()
    {
        Console.WriteLine("Screech...");
    }

    public Eagle(string name, int age)
    {
        Name = name;
        Age = age;
    }
}