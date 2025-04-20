using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class ZooStatisticsService
{
    private readonly IAnimalRepository _animalRepo;
    private readonly IEnclosureRepository _enclosureRepo;

    public ZooStatisticsService(IAnimalRepository animalRepo, IEnclosureRepository enclosureRepo)
    {
        _animalRepo = animalRepo;
        _enclosureRepo = enclosureRepo;
    }

    public (int animalCount, int emptyEnclosures) GetStats()
    {
        var animals = _animalRepo.GetAll().Count;
        var empty = _enclosureRepo.GetAll().Count(e => e.Animals.Count == 0);
        return (animals, empty);
    }
}