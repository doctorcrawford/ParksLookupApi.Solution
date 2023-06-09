using System.ComponentModel.DataAnnotations;

namespace ParksLookupApi.Models;

public class Park
{
  public int ParkId { get; set; }
  [Required]
  [StringLength(1, ErrorMessage = "Name must be at least 1 character.")]
  public string Name { get; set; }
  [Required]
  [StringLength(2, ErrorMessage = "Type must be at least 2 characters.")]
  public string Type { get; set; }
  [Required]
  [StringLength(2, ErrorMessage = "State must be at least 2 characters.")]
  public string State { get; set; }
  [Required]
  public int InceptionYear { get; set; }
  public string FeaturedAnimal { get; set; }

  public static int CurrentYear()
  {
    return DateTime.Now.Year;
  }
}


public enum ParkType
{
  Local,
  County,
  State,
  National
}