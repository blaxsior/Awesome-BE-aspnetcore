using domain.eventcommon.dto;

namespace domain.eventcommon.mapper
{
  public static class EventMetadataMapper
  {
    public static EventMetadata ToEntity(this EventDto dto, EventFrame eventFrame)
    {

      var entity = new EventMetadata
      {
        EventId = dto.eventId,
        EventFrame = eventFrame,
        Name = dto.name,
        Description = dto.description,
        StartTime = dto.startTime,
        EndTime = dto.endTime,
        Url = dto.url,
        EventType = dto.eventType
      };

      return entity;
    }

    public static EventDto ToDto(this EventMetadata entity) {
      var dto =  new EventDto {
        eventId =  entity.EventId,
        frameId = entity.EventFrame?.FrameId!,
        description = entity.Description,
        startTime = entity.StartTime,
        endTime = entity.EndTime,
        name = entity.Name,
        eventType = entity.EventType,
        url = entity.Url,
      };
      return dto;
    }
  }
}