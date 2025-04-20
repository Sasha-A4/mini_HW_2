using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class FeedingOrganizationService
{
    private readonly IFeedingScheduleRepository _repo;

    public FeedingOrganizationService(IFeedingScheduleRepository repo)
    {
        _repo = repo;
    }

    public void AddFeeding(FeedingSchedule schedule)
    {
        _repo.Add(schedule);
    }

    public List<FeedingSchedule> GetFeedingSchedule()
    {
        return _repo.GetAll();
    }
}