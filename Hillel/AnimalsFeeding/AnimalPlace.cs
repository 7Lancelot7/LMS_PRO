namespace AnimalFeeding;

public class AnimalPlace
{
    public event Action<string, AnimalPlace> FoodFinished;
    public string Name { get; set; }
    public string FeedName { get; set; }

    public void Feed(int amount)
    {
        if (amount > 0)
        {
            Console.WriteLine($"Feeding {Name} with {amount} units of {FeedName}.");
            amount -= 10;
        }
        if (amount <= 0)
        {
            OnFoodFinished(FeedName);
        }
    }
    private void OnFoodFinished(string feedName)
    {
        FoodFinished?.Invoke(feedName, this);
    }
}