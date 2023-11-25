namespace LINQ;

public  class NumbersAction
{
    public static List<int> InitList()
    {
        List<int> list = new List<int>();
        int i = 0;
        while (i <= 100)
        {
            list.Add(i++);
        }

        return list;
    }

    public static void PrintList(IEnumerable<int> list)
    {
        foreach (var item in list)
        {
            Console.Write($"{item},");
        }
    }

    public static void OnlyOdd()
    {
        List<int> list = InitList();
        var odd = list.Where(n => n % 2 == 1);
        PrintList(odd);
    }

    public static void GetSquare()
    {
        bool IsSquare(int n)
        {
            double sqrt = Math.Sqrt(n);
            return sqrt % 1 == 0;
        }

        List<int> list = InitList();
        var res = list.Where(n => IsSquare(n));
        PrintList(res);
    }

    public static void GetSumOfArray()
    {
        List<int> list = InitList();
        int sum = 0;
        var res = list.Sum();
        Console.WriteLine($"Sum of array is {res}");

        //Second option
        sum = 0;
        sum = (list[0] + list[^1]) * list.Count / 2;
        Console.WriteLine($"Sum of array is {sum}");
    }
}