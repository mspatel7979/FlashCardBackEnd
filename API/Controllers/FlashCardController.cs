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
    [HttpPost]
    public int PostFlashCard([FromQuery] int id){
        return 0;
    }
    [HttpGet("{id}")]
    public int GetFlashCardByID(int id){
        return 0;
    }
    [HttpPut("{id}")]
    public int UpdateFlashCardByID(int id){
        return 0;
    }
    [HttpDelete("{id}")]
    public int DeleteGetFlashCardByID(int id){
        return 0;
    }

}
