using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace NotesApp.Controllers;

public class NoteController : Controller
    {
        private readonly INoteProcessor _noteProcessor;

        public NoteController(INoteProcessor noteProcessor)
        {
            _noteProcessor = noteProcessor;
        }

        // GET: Note
        public IActionResult Index()
        {
            IEnumerable<Note> notes = _noteProcessor.GetAll();
            return View(notes);
        }

        // GET: Note/Detail/id
        public IActionResult Detail(Guid id)
        {
            Note noteFromDb = _noteProcessor.Get(id);
            
            if (noteFromDb is null)
                return NotFound();

            return View(noteFromDb);
        }

        // GET: Note/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Note/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Note obj)
        { 
            if (ModelState.IsValid)
            {
                _noteProcessor.Create(obj);
                TempData["success"] = "Note created successfully";// i dont understand it;
                
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET: Note/Edit/id
        public IActionResult Edit(Guid id)
        {
            var noteFromDb = _noteProcessor.Get(id);

            if (noteFromDb is null)
                return NotFound();

            return View(noteFromDb);
        }

        // POST: Note/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Note obj)
        {
            if (ModelState.IsValid)
            {
                _noteProcessor.Update(obj);
                TempData["success"] = "Note updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET: Note/Delete/id
        public IActionResult Delete(Guid id)
        {
            var noteFromDb = _noteProcessor.Get(id);

            if (noteFromDb is null)
                return NotFound();

            return View(noteFromDb);
        }

        // POST: Note/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(Guid id)
        {
            var noteFromDb = _noteProcessor.Get(id);

            if (noteFromDb is null)
                return NotFound();

            _noteProcessor.Delete(id);
            TempData["success"] = "Note deleted successfully";
            return RedirectToAction("Index");
        }
    }