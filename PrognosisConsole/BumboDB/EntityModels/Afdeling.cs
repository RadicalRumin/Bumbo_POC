using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Afdeling
{
    [Key]
    public string Naam { get; set; }
}