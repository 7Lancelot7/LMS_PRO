namespace MovieLibrary;

public class Movie
{
    public string Name { get; set; }
   public bool  IsAdult { get; set; }
    public Movie(string name, bool isAdult )
    {
        Name = name;
        IsAdult = isAdult;
    }
}