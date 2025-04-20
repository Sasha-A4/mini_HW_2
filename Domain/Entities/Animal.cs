using Domain.ValueObjects;

namespace Domain.Entities;

public class Animal
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Species { get; private set; }
    public string Name { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string Gender { get; private set; }
    public string FavoriteFood { get; private set; }
    public AnimalStatus Status { get; private set; }

    public Animal(string species, string name, DateTime birthDate, string gender, string favoriteFood)
    {
        Species = species;
        Name = name;
        BirthDate = birthDate;
        Gender = gender;
        FavoriteFood = favoriteFood;
        Status = AnimalStatus.Healthy;
    }

    public void Treat() => Status = AnimalStatus.Healthy;
}