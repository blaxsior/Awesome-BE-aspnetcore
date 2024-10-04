using domain.fcfsevent.dto;

namespace domain.fcfsevent.mapper {
  public static class FcfsEventMapper {
    public static FcfsEvent ToEntity(this FcfsEventDto dto) {
      var entity = new FcfsEvent {
        StartTime = dto.startTime,
        EndTime = dto.endTime,
        ParticipantCount = dto.participantCount,
        PrizeInfo = dto.prizeInfo,
      };

      if(dto.id != null) entity.Id = dto.id.Value;

      return entity;
    }

    public static FcfsEventDto ToDto(this FcfsEvent entity) {
      var dto = new FcfsEventDto {
        id = entity.Id,
        startTime = entity.StartTime,
        endTime = entity.EndTime,
        participantCount = entity.ParticipantCount,
        prizeInfo = entity.PrizeInfo,
      };

      return dto;
    }
  }
}