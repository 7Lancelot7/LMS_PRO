namespace AnimalFeeding;

public class AnimalsFeedProcessor
{
    private List<AnimalPlace> aviary;

    public AnimalsFeedProcessor()
    {
        aviary = new List<AnimalPlace>();
    }

    public void AddNewAnimalPlace(AnimalPlace place)
    {
        aviary.Add(place);
    }

    public void FeedAll()
    {
        Random random = new Random();
        foreach (var place in aviary)
        {
            place.Feed(random.Next(1,100));
        }
    }
}