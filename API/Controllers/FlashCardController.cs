using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class FlashCardController : ControllerBase
{
    private readonly ILogger<FlashCardController> _logger;

    public FlashCardController(ILogger<FlashCardController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public int GetAllFlashCard([FromQuery] int id){
        return 0;
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
