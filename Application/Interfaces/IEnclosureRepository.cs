using Domain.Entities;

namespace Application.Interfaces;

public interface IEnclosureRepository
{
    Enclosure GetById(Guid id);
    List<Enclosure> GetAll();
}