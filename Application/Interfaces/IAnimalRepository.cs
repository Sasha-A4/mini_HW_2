using Domain.Entities;

namespace Application.Interfaces;

public interface IAnimalRepository
{
    void Add(Animal animal);
    void Remove(Animal animal);
    Animal GetById(Guid id);
    List<Animal> GetAll();
}