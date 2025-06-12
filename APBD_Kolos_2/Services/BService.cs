using APBD_Kolos_2.Data;
using APBD_Kolos_2.DTOs;

namespace APBD_Kolos_2.Services;

public class BService : IBService
{
    private readonly DatabaseContext _context;
    
    public BService(DatabaseContext context)
    {
        _context = context;
    }
}