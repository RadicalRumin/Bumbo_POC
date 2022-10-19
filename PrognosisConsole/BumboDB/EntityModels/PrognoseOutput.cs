using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class PrognoseOutput
{
    [Key]
    public DateOnly Datum { get; set; }

    //Keypart
    [Required]
    public Filiaal Filiaal { get; set; }

    //Keypart
    [Required]
    public Afdeling Afdeling { get; set; }

    
    public int AantalMedewerkers { get; set; }
}