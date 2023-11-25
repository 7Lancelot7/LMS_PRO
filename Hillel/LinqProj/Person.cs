namespace LINQ;

public class Person
{
    public string Name { get; private set; }
    
    public int Age { get; private set; }
    
    public int Id { get; set; }

    public Person(string name, int age, int id)
    {
        Name = name;
        Age = age;
        Id = id;
    }
}