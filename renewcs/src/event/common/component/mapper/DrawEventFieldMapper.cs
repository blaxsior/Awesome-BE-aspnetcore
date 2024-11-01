using domain.drawevent;
using domain.drawevent.dto;
using domain.drawevent.mapper;
using domain.eventcommon.dto;

namespace domain.eventcommon.component
{
  public class DrawEventFieldMapper : IEventFieldMapper
  {
    public void EditEventField(EventMetadata metadata, EventDto dto)
    {
      throw new NotImplementedException();
    }

    public void FillEventDto(EventMetadata metadata, EventDto dto)
    {
      DrawEvent? drawEvent = metadata.DrawEvent;
      if(drawEvent is null) throw new Exception("cannot find draw event");

      dto.draw = drawEvent.ToDto();
    }

    public void FillEventField(EventMetadata metadata, EventDto dto)
    {
      if(dto.draw is null) throw new Exception("event must not be null");

      var drawEvent = dto.draw.ToEntity();
      metadata.DrawEvent = drawEvent;
    }
  }
}