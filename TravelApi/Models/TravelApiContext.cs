using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<TravelDest> TravelDests { get; set; }

    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<TravelDest>()
        .HasData(
          new TravelDest { TravelDestId = 1, CityName = "Oslo", CountryName = "Norway", Rating = 9, Review = "Peaceful and clean city with lots of unique art and history" },
          new TravelDest { TravelDestId = 2, CityName = "Taipei", CountryName = "Tiawan", Rating = 7, Review = "Taroko National Park is a must see!" },
          new TravelDest { TravelDestId = 3, CityName = "Victoria BC", CountryName = "Canada", Rating = 8, Review = "An overlooked gem. The Royal BC Museum is the single best dispaly of Native American artifacts and totem poles." },
          new TravelDest { TravelDestId = 4, CityName = "Kona", CountryName = "United States of America", Rating = 8, Review = "Amazing beaches and shaved ice. Be sure to take a trip around the whole island. Can be done in a weekend." },
          new TravelDest { TravelDestId = 5, CityName = "Copenhagen", CountryName = "Denmark", Rating = 8, Review ="So easy to get around by bike. Amazing bread and pastries on every corner." }
        );
    }
  }
}

