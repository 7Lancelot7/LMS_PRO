using System.Collections;
using Microsoft.EntityFrameworkCore;
using MovieLibrary;

namespace MovieLibraryEF;

public class MovieLibrary : IEnumerable
{
    
    private List<Movie> _ordinaryMovies;
    private List<Movie> _onlyAdultMovies;

    public MovieLibrary()
    {
        _onlyAdultMovies = new List<Movie>();
        _ordinaryMovies = new List<Movie>();
    }
    public MovieLibrary(DbSet<Movie> set)
    {
        _onlyAdultMovies = new List<Movie>();
        _ordinaryMovies = new List<Movie>();
        foreach (var movie in set)
        {
            if (movie.IsAdult)
            {
                _onlyAdultMovies.Add(movie);
            }
            else
            {
                _ordinaryMovies.Add(movie);
            }
        }
       
    }

    public void Add(Movie movie,AppDbContext DB)
    {
        var res = DB.Movies.Find(movie.Id);
        if (movie.IsAdult)
        {
            _onlyAdultMovies.Add(movie);
            return;
        }

        _ordinaryMovies.Add(movie);
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
    
    public void Delete(Movie movie,AppDbContext DB)
    {
        var res = DB.Movies.Find(movie.Id);
        if (movie.IsAdult)
        {
            for (int i = 0; i < _onlyAdultMovies.Count; i++)
            {
                if (_onlyAdultMovies[i].Id == res.Id)
                {
                    _onlyAdultMovies.Remove(movie);
                }
            }
            DB.Movies.Remove(res);
            DB.SaveChanges();
            return;
        }
        for (int i = 0; i < _ordinaryMovies.Count; i++)
        {
            if (_ordinaryMovies[i].Id == res.Id)
            {
                _ordinaryMovies.Remove(movie);
            }
        }
        DB.Movies.Remove(res);
        DB.SaveChanges();
        
    }
    private string FindMovieByArticul(int index)
    {
        if (DateTime.Now.TimeOfDay.Hours >= 23 || DateTime.Now.TimeOfDay.Hours < 7)
        {
            for (int i = 0; i < _onlyAdultMovies.Count; i++)
            {
                if (_onlyAdultMovies[i].Id == index)
                {
                    return _onlyAdultMovies[i].Name;
                }
            }

            for (int i = 0; i < _ordinaryMovies.Count; i++)
            {
                if (_ordinaryMovies[i].Id == index)
                {
                    return _ordinaryMovies[i].Name;
                }
            }
            return "NO FILM";
        }
        for (int i = 0; i < _ordinaryMovies.Count; i++)
        {
            if (_ordinaryMovies[i].Id == index)
            {
                return _ordinaryMovies[i].Name;
            }
        }
        return "NO FILM";
        
    }
    public string GetMovie(int movieNum)
    {
        return FindMovieByArticul(movieNum);
    }

    public string this[int index] => FindMovieByArticul(index);

    public IEnumerator GetEnumerator()
    {
        if (DateTime.Now.TimeOfDay.Hours >= 23 || DateTime.Now.TimeOfDay.Hours < 7)
        {
            var bufferList = new List<Movie>();
            bufferList.AddRange(_ordinaryMovies);
            bufferList.AddRange(_onlyAdultMovies);
            return bufferList.GetEnumerator();

        }
        return _ordinaryMovies.GetEnumerator();
    }
}