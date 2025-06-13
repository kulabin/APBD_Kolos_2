using APBD_Kolos_2.Data;
using APBD_Kolos_2.DTOs;

namespace APBD_Kolos_2.Services;

public class ExhibitionService : IExhibitionService
{
    private readonly DatabaseContext _context;
    
    public ExhibitionService(DatabaseContext context)
    {
        _context = context;
    }

    public Task<ExhibitionDto> CreateExhibition(ExhibitionDto exhibitionDto)
    {
        throw new NotImplementedException();
    }
}