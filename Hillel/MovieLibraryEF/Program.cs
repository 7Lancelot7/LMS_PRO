using Microsoft.EntityFrameworkCore;
using MovieLibrary;

namespace MovieLibraryEF
{
    class Program
    {
        public static void Add( AppDbContext DB,Movie movie)
        {
            DB.Movies.Add(movie);
            DB.SaveChanges();
        }

        public static void Delete(AppDbContext DB,Movie movie)
        {
            var res = DB.Movies.Find(movie.Id);
            DB.Movies.Remove(res);
            DB.SaveChanges();
        }

        public static void Update(AppDbContext DB,Movie movie , string name)
        {
            var res = DB.Movies.Find(movie.Id);
            res.Name=name;
            DB.SaveChanges();
        }
        public static void Update(AppDbContext DB,Movie movie , bool isadult)
        {
            var res = DB.Movies.Find(movie.Id);
            res.IsAdult = isadult;
            DB.SaveChanges();
        }
        
        
        public static void Main()
        {
            var movie1 = new Movie()
            {
                Name = "Movie1",
                IsAdult = true
            };

            var movie2 = new Movie()
            {
                Name = "Movie2",
                IsAdult = false
            };
            var movie3 = new Movie()
            {
                Name = "Movie3",
                IsAdult = true
            };
            var movie4 = new Movie()
            {
                Name = "Movie4",
                IsAdult = true
            };

            using var myDB = new AppDbContext();
            //Add(myDB,movie1);
            //Add(myDB,movie2);
            //Add(myDB,movie3);
            //Add(myDB,movie4);
            //Update(myDB,movie1,"movieChanged");
            //Update(myDB,movie2,true);
            Delete(myDB,movie4);
            MovieLibrary movieLibrary = new MovieLibrary(myDB.Movies);
            var allMovies = myDB.Movies.ToList();
            foreach (var movie in allMovies)
            {
                movieLibrary.Add(movie,myDB);
            }
        }
    }
}