using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Filiaal
{
    [Key]
    public int FiliaalId { get; set; }
    
    [Required]
    public string Naam { get; set; }

    [Required]
    public Werknemer Manager { get; set; }

    [Required]
    public Locatie Locatie { get; set; }

    [Required]
    public int MeterSchappen { get; set; }
}