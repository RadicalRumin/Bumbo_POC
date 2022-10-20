using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Activiteit
{
    [Key]
    public string Beschrijving { get; set; }
    

}
