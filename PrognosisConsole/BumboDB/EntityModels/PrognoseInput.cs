using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BumboDB.EntityModels;

public class PrognoseInput
{
    [Key]
    public DateTime Datum { get; set; }

    [Required]
    public int FiliaalID { get; set; }
    public Filiaal Filiaal { get; set; }

    [Required]
    public string EenheidType { get; set; }
    public Eenheid Eenheid { get; set; }

    public int Waarde { get; set; }
}