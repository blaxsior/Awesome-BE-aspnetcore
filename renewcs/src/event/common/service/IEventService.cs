using domain.eventcommon.dto;

namespace domain.eventcommon.service
{
  public interface IEventService
  {
    /// <summary>
    /// 조건에 따라 이벤트를 검색한다
    /// </summary>
    /// <param name="search">이벤트에 대한 검색어</param>
    /// <param name="sort">정렬 기준을 쿼리로 나타낸 것</param>
    /// <param name="type">이벤트의 타입(fcfs, draw ... )</param>
    /// <param name="page">검색할 페이지</param>
    /// <param name="size">검색하는 페이지의 크기</param>
    /// <returns></returns>
    Task<List<BriefEventDto>> SearchEvents(string search, string sort, EventType? type, int page, int size);

    /// <summary>
    /// 이벤트를 생성한다.
    /// </summary>
    /// <param name="eventDto">이벤트 관리에 사용되는 객체</param>
    Task CreateEvent(EventDto eventDto);
    /// <summary>
    /// 이벤트를 수정한다.
    /// </summary>
    /// <param name="eventDto">이벤트 관리에 사용되는 객체</param>
    Task EditEvent(EventDto eventDto);

    /// <summary>
    /// 단일 이벤트 정보를 얻는다.
    /// </summary>
    /// <param name="eventId">이벤트의 ID</param>
    /// <returns>이벤트 관리에 사용되는 객체 </returns>
    Task<EventDto?> GetEventInfo(string eventId);

    /// <summary>
    /// 이벤트를 제거한다.
    /// </summary>
    /// <param name="eventId">이벤트의 ID</param>
    Task DeleteEvent(string eventId);

    /// <summary>
    /// 이벤트를 임시로 저장한다.
    /// </summary>
    /// <param name="adminId">이벤트를 임시로 저장하는 관리자 ID</param>
    /// <param name="eventDto">이벤트 관리에 사용되는 객체</param>
    Task SaveTempEvent(long adminId, EventDto eventDto);

    /// <summary>
    /// 임시 저장된 이벤트 정보를 가져온다.
    /// </summary>
    /// <param name="adminId">이벤트를 임시로 저장한 관리자의 ID</param>
    /// <returns>임시로 저장된 이벤트 객체</returns>
    Task<EventDto> GetTempEvent(long adminId);

    /// <summary>
    /// 임시 저장된 이벤트 정보를 제거한다.
    /// </summary>
    /// <param name="adminId">이벤트를 임시로 저장한 관리자의 ID</param>
    Task ClearTempEvent(long adminId);

    /// <summary>
    /// 이벤트 검색을 위한 힌트 정보를 얻는다.
    /// </summary>
    /// <param name="search">검색어</param>
    /// <returns>이벤트 힌트 목록</returns>
    Task<List<EventSearchHintDto>> SearchHints(string search);

    /// <summary>
    /// 이벤트 프레임을 생성한다.
    /// </summary>
    /// <param name="frameId">이벤트 프레임 ID</param>
    /// <param name="name">이벤트 프레임의 표기 이름(설명)</param>
    Task CreateEventFrame(string frameId, string name);

    /// <summary>
    /// 이벤트 프레임을 검색한다.
    /// </summary>
    /// <param name="search">프레임에 대한 검색어</param>
    /// <returns>프레임 id 목록</returns>
    Task<List<string>> SearchFrames(string search);
  }
}

