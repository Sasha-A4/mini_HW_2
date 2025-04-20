namespace Domain.Entities;

public class FeedingSchedule
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Animal Animal { get; private set; }
    public DateTime FeedingTime { get; private set; }
    public string FoodType { get; private set; }

    public FeedingSchedule(Animal animal, DateTime time, string foodType)
    {
        Animal = animal;
        FeedingTime = time;
        FoodType = foodType;
    }
}