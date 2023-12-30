using System.ComponentModel.DataAnnotations;

namespace CurrencyRatesStore;

public class ExchangeRate
{
    [Key] 
    public int Id { get; set; }

    public string Ccy { get; set; }
    public string BaseCcy { get; set; }
    public decimal Buy { get; set; }
    public decimal Sale { get; set; }

    public ExchangeRate(string ccy, string baseCcy, decimal buy, decimal sale)
    {
        Ccy = ccy;
        BaseCcy = baseCcy;
        Buy = buy;
        Sale = sale;
    }
}