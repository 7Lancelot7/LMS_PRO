using Contracts;
using Microsoft.EntityFrameworkCore;

namespace NotesDAL;

public class NoteRepository : IRepository<Note>
{
    private readonly NotesDbContext _db;

    public NoteRepository()
    {
        _db = new NotesDbContext();
    }

    public IEnumerable<Note> GetAll()
    {
        return _db.Notes.ToList();
    }

    public Note Get(Guid id)
    {
        return _db.Notes.Find(id);
    }

    public void Create(Note item)
    {
        _db.Notes.Add(item);
        _db.SaveChanges();
    }

    public void Update(Note item)
    {
        //Это пока не понимаю 
        _db.Entry(item).State = EntityState.Modified;
        _db.SaveChanges();
    }

    public void Delete(Guid id)
    {
        var noteToDelete = _db.Notes.Find(id);
        if (noteToDelete is not null)
        {
            _db.Notes.Remove(noteToDelete);
            _db.SaveChanges();
        }
    }

    public void Dispose()
    {
        _db.Dispose();
    }
}