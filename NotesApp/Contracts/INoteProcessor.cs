namespace Contracts;

public interface INoteProcessor
{
    IEnumerable<Note> GetAll();

    Note Get(Guid id);

    void Create(Note note);

    void Update(Note note);

    void Delete(Guid id);

    IEnumerable<Note> SortNotesByPriority(IEnumerable<Note> notes);


}