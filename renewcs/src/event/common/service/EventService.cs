using domain.eventcommon.component;
using domain.eventcommon.dto;
using domain.eventcommon.repository;
using util;

namespace domain.eventcommon.service
{
  /// <summary>
  /// 이벤트 서비스 기본 구현체
  /// </summary>
  public class EventService : IEventService
  {
    private readonly IEventMetadataRepository emRepository;
    private readonly IEventFrameRepository efRepository;
    private readonly EventFieldMapperMatcher matcher;
    public EventService(
      IEventMetadataRepository emRepository,
      IEventFrameRepository efRepository,
      EventFieldMapperMatcher matcher
      )
    {
      this.emRepository = emRepository;
      this.efRepository = efRepository;
      this.matcher = matcher;
    }
    public Task<List<BriefEventDto>> SearchEvents(string search, string sort, EventType? type, int page, int size)
    {
      // 쿼리를 key = ASC / DESC 형식으로 파싱
      var sortDict = QueryParser.Parse(sort);
      return emRepository.FindManyBriefsAsync(search, sortDict, type, page, size);
    }
    public async Task CreateEvent(EventDto eventDto)
    {
      // 이벤트 프레임 없으면 바로 생성.
      var eventframe = await efRepository.FindByFrameIdAsync(eventDto.frameId);
      if (eventframe == null) eventframe = new EventFrame
      {
        FrameId = eventDto.frameId,
        Name = eventDto.frameId
      };

      // 이벤트 키 생성
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
      var key = new string(Enumerable.Repeat(chars, 12)
          .Select(s => s[new Random().Next(s.Length)]).ToArray());

      // 이벤트 메타데이터 생성
      EventMetadata metadata = new EventMetadata
      {
        EventId = key,
        EventFrame = eventframe,
        Name = eventDto.name,
        Description = eventDto.description,
        StartTime = eventDto.startTime,
        EndTime = eventDto.endTime,
        Url = eventDto.url,
        EventType = eventDto.eventType
      };

      // 이벤트 타입에 따라 연관된 필드 채우기.
      var mapper = matcher.GetMapper(eventDto.eventType);
      mapper.FillEventField(metadata, eventDto);

      await emRepository.CreateAsync(metadata);
    }
    public Task EditEvent(EventDto eventDto)
    {
      throw new NotImplementedException();
    }

    public Task<EventDto> GetEventInfo(string eventId)
    {
      throw new NotImplementedException();
    }

    public Task DeleteEvent(string eventId)
    {
      throw new NotImplementedException();
    }

    public Task SaveTempEvent(long adminId, EventDto eventDto)
    {
      throw new NotImplementedException();
    }

    public Task<EventDto> GetTempEvent(long adminId)
    {
      throw new NotImplementedException();
    }
    public Task ClearTempEvent(long adminId)
    {
      throw new NotImplementedException();
    }

    public Task<List<EventSearchHintDto>> SearchHints(string search)
    {
      throw new NotImplementedException();
    }

    public Task CreateEventFrame(string frameId, string name)
    {
      throw new NotImplementedException();
    }

    public Task<List<string>> SearchFrames(string search)
    {
      throw new NotImplementedException();
    }
  }
}

