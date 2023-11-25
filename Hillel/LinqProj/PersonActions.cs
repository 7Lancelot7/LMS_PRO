namespace LINQ;

public class PersonActions
{
    public  static List<Person> InitPersons()
    {
        List<Person> list = new List<Person>();
        string[] names = 
        {
            "Alice", "Bob", "Charlie", "David", "Emma", 
            "Frank", "Grace", "Henry", "Ivy", "Jack", 
            "Katherine", "Liam", "Mia", "Noah", "Olivia", 
            "Peter", "Quinn", "Ruby", "Samuel", "Tessa"
        };
        int i = 1;
        while (i<=20)
        {
            list.Add(new Person(names[i-1],new Random().Next(15, 40),i++));
        }
        return list;
    }

    public static void PrintList( IEnumerable<Person> list)
    {
        foreach (var person in list) 
        {
            Console.WriteLine($"Person id:{person.Id} Name:{person.Name}  Age:{person.Age}");
        }
    }

    public static void AboveTwenty()
    {
        List<Person> list = InitPersons();
        var res = list.Where(p => p.Age >= 20).Select(p=>p.Name);
        foreach (var VARIABLE in res)
        {
            Console.WriteLine(VARIABLE);
        }
    }

    public static void AboveTwentySorted()
    {
        List<Person> list = InitPersons();
        var res = list.Where(p => p.Age >= 20).Select(p=>new
        {
            Name=p.Name,
            Id=p.Id
        }).OrderBy(p=>p.Name);
        foreach (var person in res)
        {
            Console.WriteLine($"Person id:{person.Id} Name:{person.Name}");
        }
    }
    public static void GetTheLastOne()
    {
        List<Person> list = InitPersons();
        var res = list.Skip(list.Count-1);
        PrintList(res);
    }
     
}