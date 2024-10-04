using domain.drawevent.dto;

namespace domain.drawevent.mapper
{
  public static class DrawEventScorePolicyMapper
  {
    public static DrawEventScorePolicy ToEntity(this DrawEventScorePolicyDto dto)
    {
      var entity = new DrawEventScorePolicy
      {
        Action = dto.action,
        Score = dto.score,
      };
      if(dto.id != null) entity.Id = dto.id.Value;

      return entity;
    }

    public static DrawEventScorePolicyDto ToDto(this DrawEventScorePolicy entity)
    {
      var dto = new DrawEventScorePolicyDto
      {
        id = entity.Id,
        action = entity.Action,
        score = entity.Score,
      };

      return dto;
    }
  }
}