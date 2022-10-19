using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BumboDB.EntityModels;

public class PrognoseInput
{
    [Key]
    public DateOnly Datum { get; set; }

    //Keypart
    [Required]
    public Filiaal Filiaal { get; set; }

    //Keypart
    [Required]
    public Eenheid Eenheid { get; set; }

    public int Waarde { get; set; }
}