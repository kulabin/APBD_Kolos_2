using APBD_Kolos_2.DTOs;

namespace APBD_Kolos_2.Services;

public interface IGalleryService
{
    Task<GalleryAndExhibitionDto> getGalleryAndExhibition(int id);
}