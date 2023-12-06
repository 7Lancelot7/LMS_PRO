namespace Serialization;

[Serializable]
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }


    [NonSerialized] 
    public int Weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Weight = weight;
    }
}