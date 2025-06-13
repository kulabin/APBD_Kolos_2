using APBD_Kolos_2.Data;
using APBD_Kolos_2.DTOs;
using APBD_Kolos_2.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace APBD_Kolos_2.Services;

public class GalleryService : IGalleryService
{
    private readonly DatabaseContext _context;
    
    public GalleryService(DatabaseContext context)
    {
        _context = context;
    }
    
    public async Task<GalleryAndExhibitionDto> getGalleryAndExhibition(int id)
    {
        return new GalleryAndExhibitionDto();
    }
}