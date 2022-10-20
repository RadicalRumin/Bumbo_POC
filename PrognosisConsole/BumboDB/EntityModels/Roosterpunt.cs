using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Roosterpunt
{
    [Key]
    [Range(0, int.MaxValue)] // Only positive numbers
    public int RoosterId { get; set; }

    [Required]
    public DateTime BeginTijd { get; set; }
    
    [Required]
    public DateTime EindTijd { get; set; }

    [Required]
    public Werknemer Werknemer { get; set; }

    [Required]
    public Afdeling Afdeling { get; set; }

    public override string ToString() => $"{Afdeling}/{Werknemer} {BeginTijd}:{EindTijd}";
}