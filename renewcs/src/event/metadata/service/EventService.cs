using domain.eventmetadata.dto;

namespace domain.eventmetadata.service
{
  /// <summary>
  /// 이벤트 서비스 기본 구현체
  /// </summary>
  public class EventService : IEventService
  {
    public List<BriefEventDto> SearchEvents(string search, string sort, EventType type, int page, int size)
    {
      throw new NotImplementedException();
    }
    public void CreateEvent(EventDto eventDto)
    {
      throw new NotImplementedException();
    }
    public void EditEvent(EventDto eventDto)
    {
      throw new NotImplementedException();
    }

    public EventDto GetEventInfo(string eventId)
    {
      throw new NotImplementedException();
    }

    public void DeleteEvent(string eventId)
    {
      throw new NotImplementedException();
    }

    public void SaveTempEvent(long adminId, EventDto eventDto)
    {
      throw new NotImplementedException();
    }

    public EventDto GetTempEvent(long adminId)
    {
      throw new NotImplementedException();
    }
    public void ClearTempEvent(long adminId)
    {
      throw new NotImplementedException();
    }

    public List<EventSearchHintDto> SearchHints(string search)
    {
      throw new NotImplementedException();
    }

    public void CreateEventFrame(string frameId, string name)
    {
      throw new NotImplementedException();
    }

    public List<string> SearchFrames(string search)
    {
      throw new NotImplementedException();
    }
  }
}

