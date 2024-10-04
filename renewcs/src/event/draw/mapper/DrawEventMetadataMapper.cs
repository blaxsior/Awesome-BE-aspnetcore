using domain.drawevent.dto;

namespace domain.drawevent.mapper
{
  public static class DrawEventMetadataMapper
  {
    public static DrawEventMetadata ToEntity(this DrawEventMetadataDto dto)
    {
      var entity = new DrawEventMetadata
      {
        Count = dto.count,
        Grade = dto.grade,
        PrizeInfo = dto.prizeInfo,
      };

      if (dto.id != null) entity.Id = dto.id.Value;

      return entity;
    }

    public static DrawEventMetadataDto ToDto(this DrawEventMetadata entity)
    {
      var dto = new DrawEventMetadataDto
      {
        id = entity.Id,
        grade = entity.Grade,
        count = entity.Count,
        prizeInfo = entity.PrizeInfo
      };

      return dto;
    }
  }
}