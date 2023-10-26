using System;
using System.Threading.Channels;

namespace ExchangeRates
{
    public class Program
    {
        public static void Main()
        {
            ExchangeRates<double> exchangeRates = new ExchangeRates<double>();
            exchangeRates.ChangeRate(Currency.USD,61.1);
            exchangeRates.ChangeRate(Currency.USD,62.4);
            exchangeRates.ChangeRate(Currency.USD,63.6);
            exchangeRates.ChangeRate(Currency.EUR,70.345);
            exchangeRates.ChangeRate(Currency.EUR,71.421);
            Console.WriteLine();
            Console.WriteLine();
            exchangeRates.PrintHistory();
            Console.WriteLine();
        }
    }
}