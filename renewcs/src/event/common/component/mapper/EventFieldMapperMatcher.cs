using System.Reflection;

namespace domain.eventcommon.component
{
  public class EventFieldMapperMatcher
  {
    private readonly Dictionary<EventType, IEventFieldMapper> mappers;
    public EventFieldMapperMatcher(Dictionary<EventType, IEventFieldMapper> mappers)
    {
      this.mappers = mappers;
    }

    public IEventFieldMapper GetMapper(EventType eventType) {
      var mapper = mappers[eventType];
      if (mapper == null) throw new Exception($"cannot find mapper type for {eventType}");
      return mapper;
    }
  }
}