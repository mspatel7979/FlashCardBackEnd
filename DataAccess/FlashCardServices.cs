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
}
