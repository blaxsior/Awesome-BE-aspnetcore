using domain.drawevent.dto;

namespace domain.drawevent.mapper
{
  public static class DrawEventMapper
  {
    public static DrawEvent ToEntity(this DrawEventDto dto)
    {

      var entity = new DrawEvent
      {
        Metadatas = dto.metadata.Select(it => it.ToEntity()).ToList(),
        Policies = dto.policies.Select(it => it.ToEntity()).ToList(),
      };

      return entity;
    }

    public static DrawEventDto ToDto(this DrawEvent entity) {
      var dto = new DrawEventDto {
        metadata = entity.Metadatas.Select(it => it.ToDto()).ToList(),
        policies = entity.Policies.Select(it => it.ToDto()).ToList(),
      };

      return dto;
    }
  }
}