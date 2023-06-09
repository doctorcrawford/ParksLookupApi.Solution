using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Models;

public class ParksLookupApiContext : DbContext
{
  public DbSet<Park> Parks { get; set; }

  public ParksLookupApiContext(DbContextOptions<ParksLookupApiContext> options) : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder Builder)
  {
    Builder.Entity<Park>()
      .HasData(
        new Park { ParkId = 1, Name = "Yellowstone", Type = ParkType.National.ToString(), State = "Wyoming", InceptionYear = 1872, FeaturedAnimal = "Elk"},
        new Park { ParkId = 2, Name = "Crater Lake", Type = ParkType.National.ToString(), State = "Oregon", InceptionYear = 1902, FeaturedAnimal = "Golden-Mantled Ground Squirrel"},
        new Park { ParkId = 3, Name = "Canyonlands", Type = ParkType.National.ToString(), State = "Utah", InceptionYear = 1964, FeaturedAnimal = "Desert Bighorn Sheep"},
        new Park { ParkId = 4, Name = "Oswald West State Park", Type = ParkType.State.ToString(), State = "Oregon", InceptionYear = 1958, FeaturedAnimal = "Great Horned Owl"},
        new Park { ParkId = 5, Name = "Fahnestock", Type = ParkType.State.ToString(), State = "New York", InceptionYear = 1929, FeaturedAnimal = "Red-Shouldered Hawks"}
      );
  }
}