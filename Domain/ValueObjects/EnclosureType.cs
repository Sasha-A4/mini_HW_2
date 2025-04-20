namespace Domain.ValueObjects;

public record EnclosureType(string Value)
{
    public static EnclosureType Predator => new("Predator");
    public static EnclosureType Herbivore => new("Herbivore");
    public static EnclosureType Bird => new("Bird");
    public static EnclosureType Aquarium => new("Aquarium");
}