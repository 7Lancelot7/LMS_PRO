using Contracts;
using Microsoft.EntityFrameworkCore;

namespace NotesDAL;

public class NotesDbContext:DbContext
{
    public DbSet<Note> Notes { get; set; }
    
    public NotesDbContext()
    {
        this.Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source = notesDB.db");
        base.OnConfiguring(optionsBuilder);
    }
}