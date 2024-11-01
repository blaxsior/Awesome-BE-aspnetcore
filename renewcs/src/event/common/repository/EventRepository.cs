using common.db;
using domain.eventcommon.dto;
using Microsoft.EntityFrameworkCore;
using util.query;

namespace domain.eventcommon.repository
{
  public class EventMetadataRepository : IEventMetadataRepository
  {
    private readonly AppDbContext dbContext;
    public EventMetadataRepository(AppDbContext dbContext)
    {
      this.dbContext = dbContext;
    }

    public Task<List<BriefEventDto>> FindManyBriefsAsync(string search, Dictionary<string, SortOrder> sort, EventType? eventType, int page, int size)
    {

      // condition
      var query = dbContext.EventMetadatas
      .Where(it =>
      it.Name.Contains(search) ||
      it.EventId.Contains(search) &&
      it.EventType == eventType);
      // sort
      foreach (var (key, direction) in sort)
      {
        query = (key, direction) switch
        {
          ("eventid", SortOrder.ASC) => query.OrderBy(it => it.EventId),
          ("eventid", SortOrder.DESC) => query.OrderByDescending(it => it.EventId),
          ("name", SortOrder.ASC) => query.OrderBy(it => it.Name),
          ("name", SortOrder.DESC) => query.OrderByDescending(it => it.Name),
          (_, _) => query
        };
      }
      // paging
      query = query.Skip(page * size).Take(size);
      // projection
      var projection = query.Select(it => new BriefEventDto
      {
        Name = it.Name,
        EventId = it.EventId,
        EventType = it.EventType,
        StartTime = it.StartTime,
        EndTime = it.EndTime
      });
      // 정렬

      return projection.ToListAsync();
    }

    public async Task<EventMetadata?> FindByEventIdWithFrameAsync(string eventId)
    {
      var item = await dbContext.EventMetadatas
      .Where(it => it.EventId == eventId)
      .Include(it => it.EventFrame)
      .FirstOrDefaultAsync();
      return item;
    }

    public async Task<EventMetadata> CreateAsync(EventMetadata eventMetadata)
    {
      await dbContext.EventMetadatas.AddAsync(eventMetadata);
      await dbContext.SaveChangesAsync();
      return eventMetadata;
    }
  }
}