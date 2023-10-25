using System.Collections.Specialized;

namespace ExchangeRates;

//when we work with money better use DECIMAL because this type is mort accurate.
public class ExchangeRates<T> where T : struct
{
    
    private Dictionary<Currency, List<T>> _exchageContainer;

    /// <summary>
    /// Initializes a new instance of the Exchange Rates 
    /// </summary>
    public ExchangeRates()
    {
        _exchageContainer = new Dictionary<Currency, List<T>>();
        InitExchangeContainer();
    }

    
    private void InitExchangeContainer()
    {
        Random random = new Random();
        foreach (Currency currency in Enum.GetValues(typeof(Currency)))
        {
            var randomNumber = random.Next(1, 100);
            List<T> valueList = new List<T>();
            T randomValue = (T)Convert.ChangeType(randomNumber, typeof(T));
            valueList.Add(randomValue);
            _exchageContainer.Add(currency, valueList);
        }
        
    }
/// <summary>
/// Changes the exchange rate for a specified currency.
/// </summary>
/// <param name="currency">The currency to change the rate for.</param>
/// <param name="newValue">The new exchange rate value.</param>
/// <exception cref="Exception">Thrown when the specified currency does not exist in the container.</exception>
    public void ChangeRate(Currency currency, T newValue)
    {
        if (_exchageContainer.ContainsKey(currency))
        {
            _exchageContainer[currency].Insert(0, newValue);
            return;
        }

        throw new Exception("NO currency at ExchangeRates");
    }

    private void showHistory(int index)
    {// i dont want to get a LIST of keys from dictionary. I would like to get a "Key" by using indexers but i dont know how to realize it. Can we discuss about it on lesson?
        // i tried to use it "_exchageContainer[(Currency)i]" but console depict me my "KeyValue" and its correct so i dont know how to get a "Key"
        var KeysList = _exchageContainer.Keys.ToList();
        Console.Write(
            $"{KeysList[index]} current rate : {_exchageContainer[(Currency)index][0]}\n");
        Console.Write($"History of rates:");
        for (int j = 1; j < _exchageContainer[(Currency)index].Count; j++)
        {
            Console.Write($"[{_exchageContainer[(Currency)index][j]}]<-");
        }

        Console.WriteLine();
    }
/// <summary>
/// Prints the history of exchange rates for all currencies.
/// </summary>
    public void PrintHistory()
    {
        var KeysList = _exchageContainer.Keys.ToList();
        for (int i = 0; i < _exchageContainer.Count; i++)
        {
            var tmp = _exchageContainer[(Currency)i].Count;
            if (tmp == 1)
            {
                Console.Write(
                    $"{KeysList[i]} current rate : {_exchageContainer[(Currency)i][0]}\n");
            }
            else
            {
                showHistory(i);
            }

            Console.WriteLine(new string('*', 20));
        }
    }
}