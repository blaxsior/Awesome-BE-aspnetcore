using domain.eventcommon.dto;
using util.query;

namespace domain.eventcommon.repository
{
  public interface IEventMetadataRepository
  {
    /// <summary>
    /// 이벤트에 대한 간략한 정보들을 가져온다. 페이징 기반으로 동작.
    /// </summary>
    /// <param name="search">검색어</param>
    /// <param name="sort">정렬 기준</param>
    /// <param name="eventType">이벤트의 타입</param>
    /// <param name="page">페이지 번호</param>
    /// <param name="size">페이지 크기</param>
    /// <returns></returns>
    public Task<List<BriefEventDto>> FindManyBriefsAsync(string search, Dictionary<string, SortOrder> sort, EventType? eventType, int page, int size);

    /// <summary>
    /// 이벤트 id를 기반으로 이벤트를 가져온다.
    /// </summary>
    /// <param name="eventId">이벤트의 id</param>
    public Task<EventMetadata?> FindByEventIdWithFrameAsync(string eventId);

    /// <summary>
    /// 이벤트를 생성한다.
    /// </summary>
    /// <param name="eventMetadata">생성할 이벤트 엔티티</param>
    /// <returns>생성된 이벤트 엔티티</returns>
    public Task<EventMetadata> CreateAsync(EventMetadata eventMetadata);
  }
}