using APBD_Kolos_2.Services;
using APBD_Kolos_2.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Kolos_2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GalleryController : ControllerBase
{
    private readonly IGalleryService _aService;
    
    public GalleryController(IGalleryService aService)
    {
        _aService = aService;
    }

    [HttpGet("{id}/exhibitions")]
    public async Task<IActionResult> GetGalleryExhibitions([FromRoute] int id)
    {
        return Ok();
    }
    
    
}