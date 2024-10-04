using domain.eventcommon.dto;
using domain.fcfsevent.mapper;

namespace domain.eventcommon.component
{
  public class FcfsEventFieldMapper : IEventFieldMapper
  {
    public void EditEventField(EventMetadata metadata, EventDto dto)
    {
      throw new NotImplementedException();
    }

    public void FillEventDto(EventMetadata metadata, EventDto dto)
    {
      throw new NotImplementedException();
    }

    public void FillEventField(EventMetadata metadata, EventDto dto)
    {
      if (dto.fcfs is null) throw new Exception("event must not be null");
      
      var fcfsEvents = dto.fcfs.Select(it => it.ToEntity()).ToList();
      metadata.FcfsEvents = fcfsEvents;
    }
  }
}