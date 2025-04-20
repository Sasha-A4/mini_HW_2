using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Repositories;

public class InMemoryFeedingScheduleRepository : IFeedingScheduleRepository
{
    private readonly List<FeedingSchedule> _schedules = new();

    public void Add(FeedingSchedule schedule) => _schedules.Add(schedule);
    public List<FeedingSchedule> GetAll() => _schedules;
}