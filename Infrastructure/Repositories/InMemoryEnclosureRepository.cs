using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Repositories;

public class InMemoryEnclosureRepository : IEnclosureRepository
{
    private readonly List<Enclosure> _enclosures = new();

    public void Add(Enclosure enclosure) => _enclosures.Add(enclosure);
    public void Remove(Enclosure enclosure) => _enclosures.Remove(enclosure);
    public Enclosure GetById(Guid id) => _enclosures.First(e => e.Id == id);
    public List<Enclosure> GetAll() => _enclosures;
}