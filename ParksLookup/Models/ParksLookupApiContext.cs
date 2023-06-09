using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Models;

public class ParksLookupApiContext : DbContext
{
  public DbSet<Park> Parks { get; set; }

  public ParksLookupApiContext(DbContextOptions<ParksLookupApiContext> options) : base(options)
  {

  }
}