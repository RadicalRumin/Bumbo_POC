using System.ComponentModel.DataAnnotations;

namespace BumboDB.EntityModels;

public class Filiaal
{
    [Key]
    [Range(0, int.MaxValue)] // Only positive numbers
    public int FiliaalId { get; set; }
    
    [Required]
    public string Naam { get; set; }

    [Required]
    public int LocatieID { get; set; }

    public Locatie Locatie { get; set; }

    [Required]
    [Range(0, int.MaxValue)] // Only positive numbers
    public int MeterSchappen { get; set; }

    #region Relationships

    public ICollection<PrognoseInput> PrognoseInputs { get; set; }
    public ICollection<PrognoseOutput> PrognoseOutputs { get; set; }

    public ICollection<Werknemer> Werknemers { get; set; }

    #endregion
}