using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_Kolos_2.Models;

[Table("Gallery")]
public class Gallery
{
    [Key]
    public int GalleryID { get; set; }
    
    [MaxLength(50)]
    public string Name { get; set; }
    
    public DateTime EstablishedDate { get; set; }
    
    public ICollection<Exhibition> Exhibitions { get; set; }
}