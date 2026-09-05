using Microsoft.EntityFrameworkCore;

public class ErpDbContext : DbContext
{
    public DbSet<Sube> Subeler { get; set; }
    public DbSet<Urun> Urunler { get; set; }
    public DbSet<StokHareket> StokHareketleri { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       
        optionsBuilder.UseSqlite("Data Source=kurumsal_erp.db");
    }
}
