namespace AnimalFeeding;

public class AnimalsFeedProcessor:IDisposable
{
    

    private List<AnimalPlace> aviary;

    public AnimalsFeedProcessor()
    {
        aviary = new List<AnimalPlace>();
    }

    public void AddNewAnimalPlace(AnimalPlace place)
    {
        aviary.Add(place);
        place.FoodFinished += HandleFoodFinished;
    }

    public void FeedAll()
    {
        Random random = new Random();
        foreach (var place in aviary)
        {
            place.Feed(random.Next(1,30));
        }
    }
    private void HandleFoodFinished(string feedName, AnimalPlace place)
    {
        Console.WriteLine($"{place.Name} finished eating {feedName}. Refilling...");
    }
    

    public void Dispose()
    {
        foreach (var place in aviary)
        {
            place.FoodFinished -= HandleFoodFinished;
        }
    }
}