
using System.ComponentModel.DataAnnotations;
namespace TravelApi.Models
{
  public class TravelDest
  {
    public int TravelDestId { get; set; }
    [Required]
    public string CityName { get; set; }
    [Required]
    public string CountryName { get; set; }
    [Required]
    public string Review {get; set; }
    [Required]
    [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]

    public int Rating { get; set; }
  }
}