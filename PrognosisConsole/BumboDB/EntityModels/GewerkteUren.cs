using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BumboDB.EntityModels;

public class GewerkteUren
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime BeginTijd { get; set; }
    
   
    public DateTime EindTijd { get; set; }

    [Required]
    public Werknemer Werknemer { get; set; }

    [Required]
    public Afdeling Afdeling { get; set; }

    [Required]
    public Filiaal Filiaal { get; set; }
    
    public override string ToString() => $"{Afdeling}/{Werknemer} {BeginTijd}:{EindTijd}";
}