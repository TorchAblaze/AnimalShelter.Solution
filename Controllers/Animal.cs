using System.ComponentModel.DataAnnotations;

namespace Shelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    [Required]
    public string AdoptionStatus { get; set; }
    [Required]
    public string Biography { get; set; }
    [Required]
    public string Type { get; set; }
    [Required]
    public string Breed { get; set; }
    [Required]
    [Range(0, 100, ErrorMessage = "Age must be between 0 and 100.")]
    public int ApproximateAge { get; set; }
    [Required]
    public bool HasShots { get; set; }
    [Required]
    [Range(0, 10, ErrorMessage = "Fluffliness Level must be between 0 and 10.")]
    public int FlufflinessLevel { get; set; }
  }
}