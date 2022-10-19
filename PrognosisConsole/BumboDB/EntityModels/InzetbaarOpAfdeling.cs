using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class InzetbaarOpAfdeling
{
    [Key]
    [Required]
    public Afdeling Afdeling { get; set; }

    //[Key] Composite key in modelbuilder
    [Required]
    public Werknemer Werknemer { get; set; }
}