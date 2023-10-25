namespace DistanceBetweenPoints
{
    
    public class Program
    {
        public static void Main()
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(-5, 7);
            var distance = Point.GetDistanceBetweenPoints(point1, point2);
            
            Console.WriteLine(distance);
            
        }
    }

}       