using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Werknemer
{
    public Werknemer()
    {
        
    }
    
    [Key]
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
    public DateOnly Geboortedatum { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public DateOnly InDienstSinds { get; set; }

    [Required]
    public int Loonschaal { get; set; }

    [Required]
    public Functie Functie { get; set; }
    
    [Required]
    public Filiaal Filiaal { get; set; }
    
    [Required] 
    public Locatie Locatie { get; set; }
}