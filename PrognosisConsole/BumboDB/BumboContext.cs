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

        modelBuilder.Entity<Locatie>().HasData(locatie);

        var filiaal = new Filiaal()
        {
            FiliaalId = 1,
            Locatie = locatie,
            Naam = "Bob",
            MeterSchappen = 123,
            LocatieID = 1,
        };

        modelBuilder.Entity<Filiaal>().HasData(filiaal);

        var afdelingKassa = new Afdeling() { Naam = "Kassa" };
        var afdelingVakkenvullen = new Afdeling() { Naam = "Vakkenvullers" };

        modelBuilder.Entity<Afdeling>().HasData(afdelingKassa, afdelingVakkenvullen);

        var vakenvullen = new Activiteit()
        {
            Afdeling = afdelingVakkenvullen,
            Beschrijving = "Vakkenvullen"
        };

        var kassa = new Activiteit()
        {
            Afdeling = afdelingKassa,
            Beschrijving = "Kassa"
        };

        modelBuilder.Entity<Activiteit>().HasData(vakenvullen, kassa);

        var coli = new Eenheid() { EenheidType = "Coli" };
        var klanten = new Eenheid() { EenheidType = "Klanten" };
        var meter = new Eenheid() { EenheidType = "Meter" };

        modelBuilder.Entity<Eenheid>().HasData(coli, klanten, meter);

            modelBuilder.Entity<Normering>()
            .HasData(
                new Normering { 
                    NormeringId = 1, 
                    Eenheid = coli,
                    Activiteit = vakenvullen,
                    AantalPerUur = 2,
                    Filiaal = filiaal,
                },
                new Normering { 
                    NormeringId = 2, 
                    Eenheid = klanten,
                    Activiteit = kassa,
                    AantalPerUur = 30,
                    Filiaal = filiaal,
                },
                new Normering { 
                    NormeringId = 3, 
                    Eenheid = meter,
                    Activiteit = vakenvullen,
                    AantalPerUur = 120,
                    Filiaal = filiaal,
                }
            );

        #endregion
    }

    #region DbSets

    public DbSet<Activiteit> Activiteiten { get; set; }
    public DbSet<Afdeling> Afdelingen{ get; set; }
    public DbSet<Eenheid> Eenheden{ get; set; }
    public DbSet<Filiaal> Filialen{ get; set; }
    public DbSet<Functie> Functies{ get; set; }
    public DbSet<GewerkteUren> GewerkteUren{ get; set; }
    public DbSet<Locatie> Locaties{ get; set; }
    public DbSet<Normering> Normeringen{ get; set; }
    public DbSet<PrognoseInput> PrognoseInputs{ get; set; }
    public DbSet<PrognoseOutput> PrognoseOutputs{ get; set; }
    public DbSet<Roosterpunt> Roosterpunten{ get; set; }
    public DbSet<Werknemer> Werknemers{ get; set; }

    #endregion
}