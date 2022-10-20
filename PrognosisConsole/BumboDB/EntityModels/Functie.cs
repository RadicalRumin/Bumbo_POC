using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Functie
{
    [Key]
    public string Naam { get; set; }

    public override string ToString() => Naam;
}