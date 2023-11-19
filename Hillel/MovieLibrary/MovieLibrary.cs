using System.Collections;

namespace MovieLibrary;

public class MovieLibrary : IEnumerable
{
    private List<Movie> _ordinaryMovies;
    private List<Movie> _onlyAdultMovies;

    public MovieLibrary()
    {
        _onlyAdultMovies = new List<Movie>();
        _ordinaryMovies = new List<Movie>();
    }

    public void Add(Movie movie)
    {
        if (movie.IsAdult)
        {
            _onlyAdultMovies.Add(movie);
            return;
        }

        _ordinaryMovies.Add(movie);
    }

    public string GetMovie(int movieNum)
    {
        if (DateTime.Now.TimeOfDay.Hours >= 23 || DateTime.Now.TimeOfDay.Hours < 7)
        {
            return _onlyAdultMovies[movieNum].Name;
        }

        return _ordinaryMovies[movieNum].Name;
    }

    public Movie this[int index]
    {
        get
        {
            if (_onlyAdultMovies.Count - 1 < index)
            {
                throw new Exception("index is bigger than length of collection");
            }

            if (DateTime.Now.TimeOfDay.Hours >= 23 || DateTime.Now.TimeOfDay.Hours < 7)
            {
                return _onlyAdultMovies[index];
            }

            return _ordinaryMovies[index];
        }
        set
        {
            if (_ordinaryMovies.Count - 1 < index)
            {
                throw new Exception("index is bigger than length of collection");
            }

            if (DateTime.Now.TimeOfDay.Hours >= 23 || DateTime.Now.TimeOfDay.Hours < 7)
            {
                _onlyAdultMovies[index] = value;
                return;
            }


            _ordinaryMovies[index] = value;
        }
    }

    public IEnumerator GetEnumerator()
    {
        if (DateTime.Now.TimeOfDay.Hours >= 23 || DateTime.Now.TimeOfDay.Hours < 7)
        {
            return _onlyAdultMovies.GetEnumerator();
        }

        return _ordinaryMovies.GetEnumerator();
    }
}