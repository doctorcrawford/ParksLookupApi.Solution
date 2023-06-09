namespace ParksLookupApi.Models;

public class Park
{
  public int ParkId { get; set; }
  public string Name { get; set; }
  public string State { get; set; }
  public string FeaturedAnimal { get; set; }
  public int InceptionYear { get; set; }
}