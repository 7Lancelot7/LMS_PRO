using Contracts;
using Moq;

namespace NoteProcessor.Test;

public class NoteProcessorMockTests
{
    [Fact]
    public void GetAllTest()
    {
        Mock<IRepository<Note>> mockRepository = new Mock<IRepository<Note>>();
        NoteProcessors noteProcessors = new NoteProcessors(mockRepository.Object);
        mockRepository.Setup(repo => repo.GetAll()).Returns(new List<Note>
        {
            new Note { Id = Guid.NewGuid(), Name = "AAA", Priority = 1, Value = "To do list" },
            new Note { Id = Guid.NewGuid(), Name = "VVV", Priority = 1, Value = "Buy" },
            new Note { Id = Guid.NewGuid(), Name = "BBB", Priority = 2, Value = "Dont forget" },
            new Note { Id = Guid.NewGuid(), Name = "NNN", Priority = 5, Value = "Sunshine" }
        });
        Assert.Equal(4, noteProcessors.GetAll().Count());
    }

    [Fact]
    public void CreateTest()
    {
        List<Note> notes = new List<Note>();
        Mock<IRepository<Note>> mockRepository = new Mock<IRepository<Note>>();
        NoteProcessors noteProcessors = new NoteProcessors(mockRepository.Object);
        mockRepository.Setup(repo => repo.GetAll()).Returns(notes);

        mockRepository.Setup(repo => repo.Create(It.IsAny<Note>()))
            .Callback((Note newNote) => notes.Add(newNote));


        var initialCount = noteProcessors.GetAll().Count();

        var note = new Note { Id = Guid.NewGuid(), Name = "New Note", Priority = 3, Value = "New Note Value" };


        noteProcessors.Create(note);


        var countAfterCreate = noteProcessors.GetAll().Count();


        Assert.Equal(initialCount + 1, countAfterCreate);
    }

    [Fact]
    public void DeleteTest()
    {
        List<Note> notes = new List<Note>
        {
            new Note { Id = Guid.NewGuid(), Name = "AAA", Priority = 1, Value = "To do list" },
            new Note { Id = Guid.NewGuid(), Name = "VVV", Priority = 1, Value = "Buy" },
            new Note { Id = Guid.NewGuid(), Name = "BBB", Priority = 2, Value = "Dont forget" },
            new Note { Id = Guid.NewGuid(), Name = "NNN", Priority = 5, Value = "Sunshine" }
        };
        Mock<IRepository<Note>> mockRepository = new Mock<IRepository<Note>>();
        NoteProcessors noteProcessors = new NoteProcessors(mockRepository.Object);
        mockRepository.Setup(repo => repo.GetAll()).Returns(notes);

        mockRepository.Setup(repo => repo.Delete(It.IsAny<Guid>()))
            .Callback((Guid id) =>
            {
                var noteToRemove = notes.Find(n => n.Id == id);
                if (noteToRemove is not null)
                {
                    notes.Remove(noteToRemove);
                }
            });
        var initialCount = noteProcessors.GetAll().Count();
        var noteToDelete = notes[0];
        noteProcessors.Delete(noteToDelete.Id);
        var countAfterCreate = noteProcessors.GetAll().Count();
        Assert.Equal(initialCount - 1, countAfterCreate);
    }

    [Fact]
    public void UpdateTest()
    {
        List<Note> notes = new List<Note>
        {
            new Note { Id = Guid.NewGuid(), Name = "AAA", Priority = 1, Value = "To do list" },
        };
        Mock<IRepository<Note>> mockRepository = new Mock<IRepository<Note>>();
        NoteProcessors noteProcessors = new NoteProcessors(mockRepository.Object);
        mockRepository.Setup(repo => repo.Update(It.IsAny<Note>()))
            .Callback((Note updateNote) =>
            {
                var noteInDb = notes.FirstOrDefault(note => note.Id == updateNote.Id);
                if (noteInDb is not null)
                {
                    noteInDb.Name = updateNote.Name;
                    noteInDb.Value = updateNote.Value;
                    noteInDb.Priority = updateNote.Priority;
                }
            });
        var tmpNote = notes[0];
        var updNote = new Note { Id = tmpNote.Id, Name = "New Note", Priority = 10, Value = "New Note Value" };
        noteProcessors.Update(updNote);
        var updatedNote = notes.Find(n => n.Id == updNote.Id);
        Assert.NotNull(updatedNote);
        Assert.Equal("New Note", updatedNote.Name);
        Assert.Equal(10, updatedNote.Priority);
        Assert.Equal("New Note Value", updatedNote.Value);
    }

    [Fact]
    public void Get()
    {
        List<Note> notes = new List<Note>
        {
            new Note { Id = Guid.NewGuid(), Name = "AAA", Priority = 1, Value = "To do list" },
            new Note { Id = Guid.NewGuid(), Name = "VVV", Priority = 1, Value = "Buy" },
            new Note { Id = Guid.NewGuid(), Name = "BBB", Priority = 2, Value = "Dont forget" },
            new Note { Id = Guid.NewGuid(), Name = "NNN", Priority = 5, Value = "Sunshine" }
        };
        Mock<IRepository<Note>> mockRepository = new Mock<IRepository<Note>>();
        NoteProcessors noteProcessors = new NoteProcessors(mockRepository.Object);
        mockRepository.Setup(repo => repo.GetAll()).Returns(notes);
        mockRepository.Setup(repo => repo.Get(It.IsAny<Guid>()))
            .Callback((Guid guidId) =>
            {
                var expectedNote = notes.FirstOrDefault(note => note.Id == guidId);
                return expectedNote;
            });
               
        var noteToGet = notes[0];
        var res = noteProcessors.Get(noteToGet.Id);
        Assert.NotNull(res);
        Assert.Equal("AAA", res.Name);
        Assert.Equal(1, res.Priority);
        Assert.Equal("To do list", res.Value);
    }
}