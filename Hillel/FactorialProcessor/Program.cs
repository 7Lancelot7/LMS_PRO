namespace FactorialProcessor
{
    internal class Program
    {
        public static void Main()
        {
            FactorialProcessor factorialProcessor = new FactorialProcessor();
            factorialProcessor.Go(5,true);
            Console.WriteLine("-----------");
            factorialProcessor.Go(5, false);
            Console.WriteLine("**************");
            factorialProcessor.Go(10,true);
            Console.WriteLine("-----------");
            factorialProcessor.Go(10,false);
            Console.WriteLine("**************");
            factorialProcessor.Go(15,true);
            Console.WriteLine("-----------");
            factorialProcessor.Go(15,false);
        }
    }
}