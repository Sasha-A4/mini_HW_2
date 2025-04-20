using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnimalsController : ControllerBase
{
    private readonly InMemoryAnimalRepository _repo = new();

    [HttpPost]
    public IActionResult Add(Animal animal)
    {
        _repo.Add(animal);
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_repo.GetAll());
    }
}