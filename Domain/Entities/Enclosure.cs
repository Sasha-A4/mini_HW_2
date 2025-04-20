using Domain.ValueObjects;

namespace Domain.Entities;

public class Enclosure
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public EnclosureType Type { get; private set; }
    public int Size { get; private set; }
    public int MaxCapacity { get; private set; }
    public List<Animal> Animals { get; private set; } = new();

    public Enclosure(EnclosureType type, int size, int maxCapacity)
    {
        Type = type;
        Size = size;
        MaxCapacity = maxCapacity;
    }

    public void AddAnimal(Animal animal)
    {
        if (Animals.Count >= MaxCapacity)
            throw new InvalidOperationException("Enclosure is full.");
        Animals.Add(animal);
    }

    public void RemoveAnimal(Animal animal)
    {
        Animals.Remove(animal);
    }
}