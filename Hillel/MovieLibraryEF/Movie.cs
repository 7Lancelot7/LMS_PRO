namespace MovieLibraryEF;

public class Movie
{
    public int Id { get; private set; }
    
    private static int Count;
    
    public string Name { get; set; }
    
    public bool IsAdult { get; set; }

    public Movie(string name, bool isAdult)
    {
        Name = name;
        IsAdult = isAdult;
        Id = ++Count;
    }
    public Movie()
    {
        Id = ++Count;
    }
}