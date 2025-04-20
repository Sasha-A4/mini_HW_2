using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FeedingController : ControllerBase
{
    private readonly InMemoryFeedingScheduleRepository _repo = new();

    [HttpPost]
    public IActionResult Add(FeedingSchedule schedule)
    {
        _repo.Add(schedule);
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_repo.GetAll());
    }
}