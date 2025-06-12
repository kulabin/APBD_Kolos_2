using APBD_Kolos_2.Services;
using APBD_Kolos_2.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Kolos_2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SomethingBController : ControllerBase
{
    private readonly IBService _bService;
    
    public SomethingBController(IBService bService)
    {
        _bService = bService;
    }
}