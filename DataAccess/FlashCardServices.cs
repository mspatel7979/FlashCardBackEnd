using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class FlashCardServices
{
    private readonly CluDbContext _context;

    public FlashCardServices(CluDbContext context) {
        _context = context;
    }

    public List<Flashcard> GetAllFlashCards(){
        return _context.Flashcards.ToList();
    }

    public Flashcard PostFlashCards(Flashcard fc){
        _context.Flashcards.Add(fc);
        _context.SaveChanges();
        return fc;
    }

    public Flashcard FlashCardByID(int id){
        return _context.Flashcards.FirstOrDefault(w => w.Id == id);
    }

    public Flashcard UpdateFlashCard(Flashcard fc){
        _context.Flashcards.Update(fc);
        _context.SaveChanges();
        return fc;
    }

    public Flashcard DeleteFlashCard(Flashcard fc){
        _context.Flashcards.Remove(fc);
        _context.SaveChanges();
        return fc;
    }
}
