using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_Kolos_2.Models;
[Table("Artwork")]
public class Artwork
{
    [Key]
    public int ArtworkId { get; set; }
    
    [ForeignKey("Artist")]
    public int ArtistId { get; set; }
    
    [MaxLength(100)]
    public string Title { get; set; }
    
    public int Year { get; set; }
    
    public ICollection<Artist> Artists { get; set; }

    public ICollection<ExhibitionArtwork> ExhibitionArtworks { get; set; } = null!;
}