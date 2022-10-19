using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Filiaal
{
    [Key]
    [Range(0, int.MaxValue)] // Only positive numbers
    public int FiliaalId { get; set; }
    
    [Required]
    public string Naam { get; set; }

    [Required]
    public Werknemer Manager { get; set; }

    [Required]
    public Locatie Locatie { get; set; }

    [Required]
    [Range(0, int.MaxValue)] // Only positive numbers
    public int MeterSchappen { get; set; }
}