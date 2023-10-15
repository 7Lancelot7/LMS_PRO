namespace DistanceBetweenPoints;

public class Point
{
    /// <summary>
    /// Gets or initializes the unique identifier of the object.
    /// </summary>
    public int Id { get; init; }
    /// <summary>
    /// Gets or initializes the X coordinate of the point.
    /// </summary>
    public int X { get; init; }
    
    /// <summary>
    /// Gets or initializes the Y coordinate of the point.
    /// </summary>
    public int Y { get; init; }
    
    /// <summary>
    /// Gets the total number of Point objects created.
    /// </summary>
    public static int NumberOfPoints{get; private set; }

    /// <summary>
    /// Initializes a new instance of the Point class with the specified coordinates.
    /// </summary>
    /// <param name="x">The X coordinate of the point.</param>
    /// <param name="y">The Y coordinate of the point.</param>
    public Point(int x, int y)
    {
        X = x;
        Y = y;
        NumberOfPoints++;
        Id = NumberOfPoints;
    }
   
    /// <summary>
    /// Calculates the distance between two points.
    /// </summary>
    /// <param name="a">The first point.</param>
    /// <param name="b">The second point.</param>
    /// <returns>The distance between the two points.</returns>
    public static double GetDistanceBetweenPoints(Point a, Point b)
    {
        return Math.Round(Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)), 4);

    }

    /// <summary>
    /// Calculates the distance between "this" point and another point.
    /// </summary>
    /// <param name="b">The other point.</param>
    /// <returns>The distance between this point and the other point.</returns>
    public double GetDistanceToPoint(Point b)
    {
        return Math.Round(Math.Sqrt(Math.Pow(X - b.X, 2) + Math.Pow(Y - b.Y, 2)), 4);

    }
}