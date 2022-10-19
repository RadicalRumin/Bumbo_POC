using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BumboDB.EntityModels;

public class InzetbaarOpAfdeling
{
    [Key, Column(Order = 0)]
    public Afdeling Afdeling { get; set; }

    [Key, Column(Order = 1)]
    public Werknemer Werknemer { get; set; }
}