using Contracts;

namespace NoteProcessor;

public class NoteProcessors : INoteProcessor
{
    private readonly IRepository<Note> _repository;
    
    public NoteProcessors(IRepository<Note> repository)
    {
        _repository = repository;
    }
    
    public IEnumerable<Note> GetAll()
    {
        return SortNotesByPriority(_repository.GetAll());
    }

    public Note Get(Guid id)
    {
       return _repository.Get(id);
    }

    public void Create(Note note)
    {
        _repository.Create(note);
    }

    public void Update(Note note)
    {
        _repository.Update(note);
    }

    public void Delete(Guid id)
    {
        _repository.Delete(id);
    }

    public IEnumerable<Note> SortNotesByPriority(IEnumerable<Note> notes)
    {
        return notes.OrderByDescending(priority => priority.Priority);
    }
}

