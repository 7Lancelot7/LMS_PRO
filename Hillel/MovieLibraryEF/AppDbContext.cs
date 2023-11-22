using Microsoft.EntityFrameworkCore;
using MovieLibraryEF;

namespace MovieLibrary;

public class AppDbContext :DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public  AppDbContext()
    {
        this.Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = MovieLibraryTest.db");
        base.OnConfiguring(optionsBuilder);
    }
    
}