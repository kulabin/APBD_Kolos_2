using APBD_Kolos_2.Services;
using APBD_Kolos_2.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Kolos_2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SomethingAController : ControllerBase
{
    private readonly IAService _aService;
    
    public SomethingAController(IAService aService)
    {
        _aService = aService;
    }
    
    
}