namespace RetirementCalculation;

public static class PensionCalculate
{
    private  static double _usaIndex; 
    private static double _germanyIndex;
    private static double _polandIndex;

    static PensionCalculate()
    {
        _usaIndex = 1.67;
        _germanyIndex = 1.43;
        _polandIndex = 1.1;
    }

    private static void CheckExperience(int exp)
    {
        if (exp < 15)
        {
            throw new Exception("You dont have enough experience to get pension");
        }
    }
  
    public static double GermanyPensionCalculate(int age,int exp)
    {
        CheckExperience(exp);
        if (age >= 50 && age <= 60)
        {
            return (age + 1000) * _germanyIndex;
        }
        if (age >=61)
        {
            return (age + 1200) * _germanyIndex;
        }

        throw new Exception("You are too young");

    }
    public static double UsaPensionCalculate(int age,int exp)
    {
        CheckExperience(exp);
      
        if (age >= 50 && age <= 65)
        {
            return (age + 2000) * _usaIndex;
        }
        if (age >=66)
        {
            return (age + 3000) * _usaIndex;
        }
        throw new Exception("You are too young");
    }
    public static double PolandPensionCalculate(int age,int exp)
    {
        CheckExperience(exp);
        if (age >= 45 && age <= 55)
        {
            return (age + 800) * _polandIndex;
        }
        if (age >=56)
        {
            return (age + 1100) * _polandIndex;
        }
        throw new Exception("You are too young");
    }
}