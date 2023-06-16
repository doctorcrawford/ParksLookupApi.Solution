using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ParksLookupApi.Models;

public class ParksLookupApiContext : IdentityDbContext<IdentityUser>
{
  public DbSet<Park> Parks { get; set; }
  public ParksLookupApiContext(DbContextOptions<ParksLookupApiContext> options) : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Park>()
      .HasData(
        new Park { ParkId = 1, Name = "Yellowstone", State = "Wyoming", InceptionYear = 1872, FeaturedAnimal = "Elk" },
        new Park { ParkId = 2, Name = "Crater Lake", State = "Oregon", InceptionYear = 1902, FeaturedAnimal = "Golden-Mantled Ground Squirrel" },
        new Park { ParkId = 3, Name = "Canyonlands", State = "Utah", InceptionYear = 1964, FeaturedAnimal = "Desert Bighorn Sheep" },
        new Park { ParkId = 4, Name = "Oswald West State Park", State = "Oregon", InceptionYear = 1958, FeaturedAnimal = "Great Horned Owl" },
        new Park { ParkId = 5, Name = "Fahnestock", State = "New York", InceptionYear = 1929, FeaturedAnimal = "Red-Shouldered Hawks" }
      );

    base.OnModelCreating(builder);
  }
}