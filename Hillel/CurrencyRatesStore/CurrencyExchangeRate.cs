using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CurrencyExchangeRate
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Ccy { get; set; }
    public string Base_Ccy { get; set; }
    public decimal Buy { get; set; }
    public decimal Sale { get; set; }
}