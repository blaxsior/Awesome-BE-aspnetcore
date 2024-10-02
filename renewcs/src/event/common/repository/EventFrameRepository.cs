using common.db;
using domain.eventcommon.dto;
using Microsoft.EntityFrameworkCore;
using util.query;

namespace domain.eventcommon.repository
{
  public class EventFrameRepository : IEventFrameRepository
  {
    private readonly AppDbContext context;
    public EventFrameRepository(AppDbContext context)
    {
      this.context = context;
    }
    public Task<EventFrame?> FindByFrameIdAsync(string frameId)
    {
      return context.EventFrames.Where(it => it.FrameId == frameId).SingleOrDefaultAsync();
    }
  }
}