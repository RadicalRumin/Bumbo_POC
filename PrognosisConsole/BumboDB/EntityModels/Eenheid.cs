using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Eenheid
{
    [Key]
    public string EenheidType { get; set; }
}