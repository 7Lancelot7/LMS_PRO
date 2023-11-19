using System.Threading.Channels;

namespace MovieLibrary
{
    class Program
    {
        public static void Main()
        {
            DateTime dateTime = new DateTime();
            MovieLibrary movieLibrary = new MovieLibrary();
            movieLibrary.Add(new Movie("A", true));
            movieLibrary.Add(new Movie("B", false));
            movieLibrary.Add(new Movie("C", true));
            movieLibrary.Add(new Movie("D", false));
            movieLibrary.Add(new Movie("E", true));
            Console.WriteLine(DateTime.Now.TimeOfDay.Hours);
            Console.WriteLine(movieLibrary[0].Name);
            Console.WriteLine(movieLibrary.GetMovie(1));
            
            foreach (Movie movie in movieLibrary)
            {
                Console.WriteLine(movie.Name);
            }
        }
    }
}

