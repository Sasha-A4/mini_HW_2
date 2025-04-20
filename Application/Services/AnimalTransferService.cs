using Domain.Entities;
using Application.Interfaces;

namespace Application.Services;

public class AnimalTransferService
{
    private readonly IAnimalRepository _animalRepo;
    private readonly IEnclosureRepository _enclosureRepo;

    public AnimalTransferService(IAnimalRepository animalRepo, IEnclosureRepository enclosureRepo)
    {
        _animalRepo = animalRepo;
        _enclosureRepo = enclosureRepo;
    }

    public void Transfer(Guid animalId, Guid toEnclosureId)
    {
        var animal = _animalRepo.GetById(animalId);
        var from = _enclosureRepo.GetAll().FirstOrDefault(e => e.Animals.Contains(animal));
        var to = _enclosureRepo.GetById(toEnclosureId);

        from?.RemoveAnimal(animal);
        to.AddAnimal(animal);
    }
}