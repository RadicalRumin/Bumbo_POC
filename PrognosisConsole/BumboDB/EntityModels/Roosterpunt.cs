using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Roosterpunt
{
    [Key]
    public int RoosterId { get; set; }

    [Required]
    public DateTime BeginTijd { get; set; }
    
    [Required]
    public DateTime EindTijd { get; set; }

    [Required]
    public Werknemer Werknemer { get; set; }

    [Required]
    public Afdeling Afdeling { get; set; }
}