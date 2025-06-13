using APBD_Kolos_2.Services;
using APBD_Kolos_2.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Kolos_2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExhibitionController : ControllerBase
{
    private readonly IExhibitionService _bService;
    
    public ExhibitionController(IExhibitionService bService)
    {
        _bService = bService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateExhibition([FromBody] ExhibitionDto dto)
    {
        return CreatedAtAction("created new exhibition","");
    }
}