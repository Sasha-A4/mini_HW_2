using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EnclosuresController : ControllerBase
{
    private readonly InMemoryEnclosureRepository _repo = new();

    [HttpPost]
    public IActionResult Add(Enclosure enclosure)
    {
        _repo.Add(enclosure);
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_repo.GetAll());
    }
}