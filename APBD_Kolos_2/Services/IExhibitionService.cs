using APBD_Kolos_2.DTOs;

namespace APBD_Kolos_2.Services;

public interface IExhibitionService
{
    Task<ExhibitionDto> CreateExhibition(ExhibitionDto exhibitionDto);
}