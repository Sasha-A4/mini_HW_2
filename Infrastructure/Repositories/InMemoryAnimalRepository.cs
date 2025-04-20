using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Repositories;

public class InMemoryAnimalRepository : IAnimalRepository
{
    private readonly List<Animal> _animals = new();

    public void Add(Animal animal) => _animals.Add(animal);
    public void Remove(Animal animal) => _animals.Remove(animal);
    public Animal GetById(Guid id) => _animals.First(a => a.Id == id);
    public List<Animal> GetAll() => _animals;
}