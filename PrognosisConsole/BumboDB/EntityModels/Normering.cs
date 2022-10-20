using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BumboDB.EntityModels;

public class Normering
{
    [Key]
    [Range(0, int.MaxValue)] // Only positive numbers
    public int NormeringId { get; set; }

    [Required]
    public Eenheid Eenheid { get; set; }

    [Required]
    public Activiteit Activiteit { get; set; }

    //Not required because a default may exist that is not tied to a Filiaal
    public Filiaal Filiaal { get; set; }

    [Required]
    public int AantalPerUur { get; set; }

    public override string ToString() => $"{Eenheid}: {AantalPerUur}x{Eenheid} per hour during {Activiteit} activity";
}