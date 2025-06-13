using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_Kolos_2.Models;

[Table("Exhibition_Artwork")]
[PrimaryKey(nameof(ExhibitionId),nameof(ArtworkId))]
public class ExhibitionArtwork
{
    [ForeignKey(nameof(ExhibitionId))]
    public int ExhibitionId { get; set; }
    
    [ForeignKey(nameof(ArtworkId))]
    public int ArtworkId { get; set; }
    
    [Column(TypeName = "numeric")]
    [Precision(10,2)]
    public double InsuranceValue { get; set; }
}