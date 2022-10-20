using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BumboDB.EntityModels;

public class PrognoseOutput
{
    [Key]
    public DateTime Datum { get; set; }

    [Required]
    public int FiliaalId { get; set; }

    public Filiaal Filiaal { get; set; }

    [Required]
    public string AfdelingNaam { get; set; }

    public Afdeling Afdeling { get; set; }

    
    public int AantalMedewerkers { get; set; }
}