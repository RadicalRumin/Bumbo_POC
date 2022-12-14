using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Afdeling
{
    [Key]
    public string Naam { get; set; }

    public ICollection<Werknemer> Werknemers { get; set; }

    #region Relationships

    public ICollection<PrognoseOutput> PrognoseOutputs { get; set; }

    public ICollection<Activiteit> ActiviteitFK { get; set; }


    #endregion

    public override string ToString() => Naam;
}