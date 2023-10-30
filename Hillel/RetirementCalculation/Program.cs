using System;

namespace RetirementCalculation
{


    public class Program
    {
        public static void Main()
        {
            Person person1 = new Person("Alex", 56, 23);
            CalculateRetirement calculateRetirement1 = PensionCalculate.GermanyPensionCalculate;
            Person person2 = new Person("Vova", 65, 20);
            CalculateRetirement calculateRetirement2 = PensionCalculate.PolandPensionCalculate;
            Person person3 = new Person("Kirill", 44, 14);
            CalculateRetirement calculateRetirement3 = PensionCalculate.UsaPensionCalculate;

            Console.WriteLine(person1.GetRetiremetnValue(calculateRetirement1));
            Console.WriteLine(person2.GetRetiremetnValue(calculateRetirement2));
            Console.WriteLine(person3.GetRetiremetnValue(calculateRetirement3));
        }
    }
}