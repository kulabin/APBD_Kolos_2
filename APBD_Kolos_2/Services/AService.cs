using APBD_Kolos_2.Data;
using APBD_Kolos_2.DTOs;

namespace APBD_Kolos_2.Services;

public class AService : IAService
{
    private readonly DatabaseContext _context;
    
    public AService(DatabaseContext context)
    {
        _context = context;
    }
    
}