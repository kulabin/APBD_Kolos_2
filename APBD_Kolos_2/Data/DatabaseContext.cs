using Microsoft.EntityFrameworkCore;
using APBD_Kolos_2.Models;

namespace APBD_Kolos_2.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
    
    public DbSet<A> A { get; set; }
    public DbSet<B> B { get; set; }
    public DbSet<C> C { get; set; }
    public DbSet<D> D { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<A>().HasData("A");
        modelBuilder.Entity<B>().HasData("B");
        modelBuilder.Entity<C>().HasData("C");
        modelBuilder.Entity<D>().HasData("D");
    }
    
}