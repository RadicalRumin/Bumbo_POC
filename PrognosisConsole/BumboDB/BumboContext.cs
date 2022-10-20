using BumboDB.EntityModels;
using Microsoft.EntityFrameworkCore;


namespace BumboDB;

public sealed class BumboContext : DbContext
{
    public BumboContext()
    {
            
    }

    public BumboContext(DbContextOptions<BumboContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
        
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=BumboDB;Integrated Security=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        #region CompositeKeys

        modelBuilder.Entity<PrognoseInput>()
            .HasKey(c => new { c.Datum, c.FiliaalID, c.EenheidType });

        #endregion

        #region Relationships

        modelBuilder.Entity<PrognoseInput>()
            .HasOne(p => p.Eenheid)
            .WithMany(p => p.PrognoseInputs)
            .HasForeignKey(p => p.EenheidType);
        
        modelBuilder.Entity<PrognoseInput>()
            .HasOne(p => p.Filiaal)
            .WithMany(p => p.PrognoseInputs)
            .HasForeignKey(p => p.FiliaalID);
        
        modelBuilder.Entity<PrognoseOutput>()
            .HasKey(c => new { c.Datum, c.FiliaalId, c.AfdelingNaam });

        modelBuilder.Entity<PrognoseOutput>()
            .HasOne(p => p.Afdeling)
            .WithMany(p => p.PrognoseOutputs)
            .HasForeignKey(p => p.AfdelingNaam);
        
        modelBuilder.Entity<PrognoseOutput>()
            .HasOne(p => p.Filiaal)
            .WithMany(p => p.PrognoseOutputs)
            .HasForeignKey(p => p.FiliaalId);
        
        
        modelBuilder.Entity<Werknemer>()
            .HasOne(w => w.Locatie)
            .WithMany(l => l.Werknemers)
            .HasForeignKey(w => w.LocatieID)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Filiaal>()
            .HasOne(f => f.Locatie)
            .WithMany(l => l.Filialen)
            .HasForeignKey(f => f.FiliaalId)
            .OnDelete(DeleteBehavior.NoAction);

        #endregion

        #region SeedData

        var locatie = new Locatie()
        {
            Huisnummer = "12345",
            Plaats = "Den Bosch",
            Postcode = "1234AB",
            LocatieId = 1
        };

        var filiaal = new Filiaal()
        {
            FiliaalId = 1,
            Locatie = locatie,
            Naam = "Bob",
            MeterSchappen = 123,
            LocatieID = 1,
        };

        var vakenvullen = new Activiteit()
        {
            Afdeling = new Afdeling() { Naam = "Vakkenvullers" },
            Beschrijving = "Vakkenvullen",
        };

        var kassa = new Activiteit()
        {
            Afdeling = new Afdeling() { Naam = "Kassa" },
            Beschrijving = "Kassa"
        };

        modelBuilder.Entity<Normering>()
            .HasData(
                new Normering { 
                    NormeringId = 1, 
                    Eenheid = new Eenheid() { EenheidType = "Coli" },
                    Activiteit = vakenvullen,
                    AantalPerUur = 2,
                    Filiaal = filiaal,
                },
                new Normering { 
                    NormeringId = 2, 
                    Eenheid = new Eenheid() { EenheidType = "Klanten" },
                    Activiteit = kassa,
                    AantalPerUur = 30,
                    Filiaal = filiaal,
                },
                new Normering { 
                    NormeringId = 3, 
                    Eenheid = new Eenheid() { EenheidType = "Meter" },
                    Activiteit = vakenvullen,
                    AantalPerUur = 120,
                    Filiaal = filiaal,
                }
            );

        #endregion
    }

    #region DbSets

    public DbSet<Activiteit> Activiteiten;
    public DbSet<Afdeling> Afdelingen;
    public DbSet<Eenheid> Eenheden;
    public DbSet<Filiaal> Filialen;
    public DbSet<Functie> Functies;
    public DbSet<GewerkteUren> GewerkteUren;
    public DbSet<Locatie> Locaties;
    public DbSet<Normering> Normeringen;
    public DbSet<PrognoseInput> PrognoseInputs;
    public DbSet<PrognoseOutput> PrognoseOutputs;
    public DbSet<Roosterpunt> Roosterpunten;
    public DbSet<Werknemer> Werknemers;

    #endregion
}