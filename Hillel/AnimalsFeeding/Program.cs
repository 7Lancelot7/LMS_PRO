using System;

namespace AnimalFeeding
{
    internal class Program
    {
        public static void Main()
        {
            using (AnimalsFeedProcessor processor = new AnimalsFeedProcessor())
            {
                AnimalPlace lion = new AnimalPlace { Name = "Lion", FeedName = "Meat" };
                AnimalPlace elephant = new AnimalPlace { Name = "Elephant", FeedName = "Hay" };
                processor.AddNewAnimalPlace(lion);
                processor.AddNewAnimalPlace(elephant);
                processor.FeedAll();
            }
        }
    }
}