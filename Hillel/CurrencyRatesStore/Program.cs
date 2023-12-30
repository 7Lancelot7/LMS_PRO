using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CurrencyRatesStore
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response =
                        await httpClient.GetStringAsync("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5");
                    Console.WriteLine(response);

                    var rates = JsonConvert.DeserializeObject<List<CurrencyExchangeRate>>(response,
                        new JsonSerializerSettings
                        {
                            FloatParseHandling = FloatParseHandling.Decimal
                        });

                    if (rates is null)
                    {
                        throw new Exception("rates is null");
                    }

                    using (var context = new CurrencyContext())
                    {
                        foreach (CurrencyExchangeRate rate in rates)
                        {
                            if (rate.Base_Ccy is not null && rate.Ccy is not null && rate.Buy > 0 &&
                                rate.Buy > 0)
                            {
                                context.CurrencyExchangeRates.Add(rate);
                            }
                        }

                        context.SaveChanges();
                    }
                }

                Console.WriteLine("Дані про курс валют успішно збережені в базі даних.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка при збереженні в базу даних: {ex.Message}");
    
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                    Console.WriteLine($"Inner Exception StackTrace: {ex.InnerException.StackTrace}");
                }
            }

        }
    }
}