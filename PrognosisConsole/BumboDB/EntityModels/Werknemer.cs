using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BumboDB.EntityModels;

public class Werknemer
{
    public Werknemer()
    {
        
    }
    
    [Key]
    // [RegularExpression("")] TODO look up format
    public string BID { get; set; }
    
    [Required]
    public string Voornaam { get; set; }
    
    [Required]
    public string Achternaam { get; set; }
    
    public string Tussenvoegsel { get; set; }
    
    [Required]
    [Phone]
    public string Telefoonnummer { get; set; }

    [Required]
    public DateTime Geboortedatum { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public DateTime InDienstSinds { get; set; }

    [Required]
    public int Loonschaal { get; set; }

    [Required]
    public Functie Functie { get; set; }
    
    [NotMapped]
    public bool IsManager
    {
        get => Functie.Naam == "Manager";
    }
    
    [Required]
    public Filiaal Filiaal { get; set; }
    
    [Required] 
    public int LocatieID { get; set; }
    public Locatie Locatie { get; set; }

    public Afdeling Afdeling { get; set; }

    public override string ToString()
    {
        return $"BID: {BID}, {Voornaam} {Tussenvoegsel} {Achternaam}";
    }
}