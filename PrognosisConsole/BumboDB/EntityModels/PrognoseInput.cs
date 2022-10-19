using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BumboDB.EntityModels;

public class PrognoseInput
{
    [Key, Column(Order = 0)]
    public DateOnly Datum { get; set; }

    [Key, Column(Order = 1)]
    public Filiaal Filiaal { get; set; }

    [Key, Column(Order = 2)]
    public Eenheid Eenheid { get; set; }

    public int Waarde { get; set; }
}