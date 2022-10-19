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
    }

    #region DbSets

    

    #endregion
}