using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BumboDB.EntityModels;

public class PrognoseOutput
{
    [Key, Column(Order = 0)]
    public DateOnly Datum { get; set; }

    [Key, Column(Order = 1)]
    public Filiaal Filiaal { get; set; }

    [Key, Column(Order = 2)]
    public Afdeling Afdeling { get; set; }

    
    public int AantalMedewerkers { get; set; }
}