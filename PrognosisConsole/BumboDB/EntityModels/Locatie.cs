using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Locatie
{
    [Key] 
    public int LocatieId { get; set; }

    [Required]
    public string Postcode { get; set; }

    [Required]
    public string Huisnummer { get; set; }  

    [Required]
    public string Plaats { get; set; }
}