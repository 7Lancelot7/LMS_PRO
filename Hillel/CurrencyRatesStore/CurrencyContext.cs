using Microsoft.EntityFrameworkCore;

namespace CurrencyRatesStore;

public class CurrencyContext :DbContext
{
    public DbSet<CurrencyExchangeRate> CurrencyExchangeRates { get; set; }

    public  CurrencyContext()
    {
        this.Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = CurrencyDB.db");
        base.OnConfiguring(optionsBuilder);
    }
    
}