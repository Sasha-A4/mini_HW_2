namespace Domain.ValueObjects;

public record AnimalStatus(string Value)
{
    public static AnimalStatus Healthy => new("Healthy");
    public static AnimalStatus Sick => new("Sick");
}