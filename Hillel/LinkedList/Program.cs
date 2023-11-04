
namespace LinkedList
{
    public class Program
    {
        public static void Main()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Print();
            linkedList.Delete(1);
            linkedList.Delete(2);
            linkedList.Print();
            linkedList.Delete(3);
            linkedList.Print();
            
        }
    }
}