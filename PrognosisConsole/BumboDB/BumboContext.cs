﻿using BumboDB.EntityModels;
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
        
        //TODO: fix composite keys
        //Composite keys
        // modelBuilder.Entity<InzetbaarOpAfdeling>()
        //     .HasKey(c => new { c.Afdeling.Naam, c.Werknemer.BID });
        //
        // modelBuilder.Entity<PrognoseInput>()
        //     .HasKey(c => new { c.Datum, c.Filiaal.FiliaalId, c.Eenheid.EenheidType });
        //
        // modelBuilder.Entity<PrognoseOutput>()
        //     .HasKey(c => new { c.Datum, c.Filiaal.FiliaalId, c.Afdeling.Naam });
        
    }

    #region DbSets

    public DbSet<Activiteit> Activiteiten;
    public DbSet<Afdeling> Afdelingen;
    public DbSet<Eenheid> Eenheden;
    public DbSet<Filiaal> Filialen;
    public DbSet<Functie> Functies;
    public DbSet<GewerkteUren> GewerkteUren;
    public DbSet<InzetbaarOpAfdeling> InzetbaarOpAfdeling;
    public DbSet<Locatie> Locaties;
    public DbSet<Normering> Normeringen;
    public DbSet<PrognoseInput> PrognoseInputs;
    public DbSet<PrognoseOutput> PrognoseOutputs;
    public DbSet<Roosterpunt> Roosterpunten;
    public DbSet<Werknemer> Werknemers;

    #endregion
}