using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Entities;
using DataAccess;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class FlashCardController : ControllerBase
{
    private readonly ILogger<FlashCardController> _logger;
    private readonly FlashCardServices _repo;

    public FlashCardController(ILogger<FlashCardController> logger, FlashCardServices repo)
    {
        _logger = logger;
        _repo = repo;
    }

    [HttpGet("All")]
    public List<Flashcard> GetAllFlashCard(){
        return _repo.GetAllFlashCards();
    }
    [HttpPost("Add")]
    public Flashcard AddFlashCard(Flashcard fc){
        return _repo.PostFlashCards(fc);;
    }
    [HttpGet("{id}")]
    public Flashcard GetFlashCardByID(int id){
        return _repo.FlashCardByID(id);
    }
    [HttpPut("Update")]
    public Flashcard UpdateFlashCardByID(Flashcard fc){
        return _repo.UpdateFlashCard(fc);
    }
    [HttpDelete("Delete")]
    public Flashcard DeleteGetFlashCardByID(Flashcard fc){
        return _repo.DeleteFlashCard(fc);
    }

}
