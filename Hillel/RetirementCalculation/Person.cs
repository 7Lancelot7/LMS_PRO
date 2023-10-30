using System.Linq.Expressions;

namespace RetirementCalculation;
public delegate double CalculateRetirement(int age, int experience);
public class Person
{
    public string Name { get; set; }


    public int Age { get; set; }

    public int Experience { get; set; }

    public Person(string name, int age, int experience)
    {
        Name = name;
        Age = age;
        Experience = experience;
    }

    public double? GetRetiremetnValue(CalculateRetirement calculateRetirement)
    {
        //Which one is  variant correct?
        // double? res = calculateRetirement?.Invoke(Age,Experience);
        // if (res is null)
        // {
        //     throw new NullReferenceException("delegate returned null");
        // }
        //
        // return res;

        return calculateRetirement?.Invoke(Age, Experience);
    }
}