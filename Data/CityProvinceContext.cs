using lab05.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class CityProvinceContext : DbContext
{
    public CityProvinceContext(DbContextOptions options)
        : base(options)
    {
    }

     protected override void OnModelCreating( ModelBuilder builder){
        builder.Entity<Province>().Property(m => m.ProvinceCode).IsRequired();
        builder.Entity<City>().Property(c =>  c.CityId).IsRequired();

        builder.Entity<Province>().ToTable("Province");
        builder.Entity<City>().ToTable("City");

        builder.Seed();
    }


    public DbSet<City> Cities { get; set; }
    public DbSet<Province> Provinces { get; set; }
}
