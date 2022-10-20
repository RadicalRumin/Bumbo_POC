using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Locatie
{
    [Key] 
    [Range(0, int.MaxValue)] // Only positive numbers
    public int LocatieId { get; set; }

    [Required]
    public string Postcode { get; set; }

    [Required]
    public string Huisnummer { get; set; }  

    [Required]
    public string Plaats { get; set; }

    public ICollection<Werknemer> Werknemers { get; set; }

    public ICollection<Filiaal> Filialen { get; set; }

    public override string ToString() => $"{Plaats}, {Postcode} {Huisnummer}";
}