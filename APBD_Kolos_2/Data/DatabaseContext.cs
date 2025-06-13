using Microsoft.EntityFrameworkCore;
using APBD_Kolos_2.Models;

namespace APBD_Kolos_2.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
    
    public DbSet<Gallery> Gallery { get; set; }
    public DbSet<Exhibition> Exhibition { get; set; }
    public DbSet<Artist> Artist { get; set; }
    public DbSet<Artwork> Artwork { get; set; }
    public DbSet<ExhibitionArtwork> ExhibitionArtwork { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gallery>().HasData(new List<Gallery>()
        {
            new Gallery(){GalleryID = 1,Name = "A", EstablishedDate = DateTime.Parse("2021-09-01")},
            new Gallery(){GalleryID = 2,Name = "B",EstablishedDate = DateTime.Parse("2021-09-01")},
            new Gallery(){GalleryID = 3,Name = "C",EstablishedDate = DateTime.Parse("2021-09-01")}
        });
        modelBuilder.Entity<Exhibition>().HasData(new List<Exhibition>()
        {
            new Exhibition(){ExhibitionId = 1,GalleryId = 1,Title = "AA",StartDate = DateTime.Parse("2021-09-01"),EndDate = DateTime.Parse("2021-09-02"),NumberOfArtworks = 4},
            new Exhibition(){ExhibitionId = 2,GalleryId = 1,Title = "AAB",StartDate = DateTime.Parse("2021-09-02"),EndDate = DateTime.Parse("2021-09-03"),NumberOfArtworks = 5},
            new Exhibition(){ExhibitionId = 3,GalleryId = 2,Title = "AAC",StartDate = DateTime.Parse("2021-09-03"),EndDate = DateTime.Parse("2021-09-04"),NumberOfArtworks = 3},
            new Exhibition(){ExhibitionId = 4,GalleryId = 2,Title = "AAD",StartDate = DateTime.Parse("2021-09-04"),EndDate = DateTime.Parse("2021-09-05"),NumberOfArtworks = 6},
            new Exhibition(){ExhibitionId = 5,GalleryId = 3,Title = "AAE",StartDate = DateTime.Parse("2021-09-05"),EndDate = DateTime.Parse("2021-09-06"),NumberOfArtworks = 2},
            new Exhibition(){ExhibitionId = 6,GalleryId = 4,Title = "AAF",StartDate = DateTime.Parse("2021-09-06"),EndDate = DateTime.Parse("2021-09-07"),NumberOfArtworks = 7},
        });
        modelBuilder.Entity<Artist>().HasData(new List<Artist>()
        {
            new Artist(){ArtistId = 1,BirthDate = DateTime.Parse("2000-09-01"),FirstName = "A",LastName = "B"},
            new Artist(){ArtistId = 2,BirthDate = DateTime.Parse("2000-09-02"),FirstName = "B",LastName = "C"},
            new Artist(){ArtistId = 3,BirthDate = DateTime.Parse("2000-09-03"),FirstName = "C",LastName = "D"},
            new Artist(){ArtistId = 4,BirthDate = DateTime.Parse("2000-09-04"),FirstName = "D",LastName = "E"},
            new Artist(){ArtistId = 5,BirthDate = DateTime.Parse("2000-09-05"),FirstName = "E",LastName = "F"}
        });
        modelBuilder.Entity<Artwork>().HasData(new List<Artwork>()
        {
            new Artwork(){ArtworkId = 1,ArtistId = 1,Title = "ASADASDAd",Year = 2012},
            new Artwork(){ArtworkId = 2,ArtistId = 2,Title = "ASADA",Year = 2013},
            new Artwork(){ArtworkId = 3,ArtistId = 3,Title = "ASSDAd",Year = 2014},
            new Artwork(){ArtworkId = 4,ArtistId = 4,Title = "ADASDAd",Year = 2015},
            new Artwork(){ArtworkId = 5,ArtistId = 5,Title = "ASADqweqwdsad",Year = 2016},
        });
        modelBuilder.Entity<ExhibitionArtwork>().HasData(new List<ExhibitionArtwork>()
        {
            new ExhibitionArtwork() {ExhibitionId = 1,ArtworkId = 1,InsuranceValue = 1200.33},
            new ExhibitionArtwork() {ExhibitionId = 2,ArtworkId = 2,InsuranceValue = 1040.24},
            new ExhibitionArtwork() {ExhibitionId = 3,ArtworkId = 3,InsuranceValue = 1030.64},
            new ExhibitionArtwork() {ExhibitionId = 4,ArtworkId = 4,InsuranceValue = 1110.65},
            new ExhibitionArtwork() {ExhibitionId = 5,ArtworkId = 5,InsuranceValue = 10055.92},
            new ExhibitionArtwork() {ExhibitionId = 6,ArtworkId = 1,InsuranceValue = 101120.46},
            new ExhibitionArtwork() {ExhibitionId = 7,ArtworkId = 2,InsuranceValue = 1012310.57},
            
        });
    }
    
}