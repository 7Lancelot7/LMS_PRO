using System.Diagnostics;

namespace FactorialProcessor;

public class FactorialProcessor
{
    public void Go(int param, bool parallelMode)
    {
       
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        if (param > 15 || param < 1)
        {
            throw new FormatException("Incorrect format for param.Please enter value between 1 and 15");
        }

        if (parallelMode)
        {
            Parallel.For(1, param + 1, i =>
            {
               
                Console.WriteLine($"Factorial of {i} is {CalculateFactorial(i)}");
            });
        }
        else
        {
            
            for (int i = 1; i <= param; i++)
            {
                Console.WriteLine($"Factorial {i} = {CalculateFactorial(i)}");
            }
        }

        stopwatch.Stop();
       
        Console.WriteLine($"Program running time in milliseconds :{stopwatch.ElapsedMilliseconds}");
    }

    private int CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}