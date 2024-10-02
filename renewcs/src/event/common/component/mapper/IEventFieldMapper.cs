using domain.eventcommon.dto;

namespace domain.eventcommon.component
{
  /// <summary>
  /// 특정 이벤트 타입이 가진 데이터를 처리하는 클래스
  /// </summary>
  public interface IEventFieldMapper
  {
    /// <summary>
    /// 이벤트 dto의 데이터를 기반으로 이벤트 엔티티 정보를 채운다.
    /// </summary>
    /// <param name="metadata">이벤트 객체</param>
    /// <param name="dto">이벤트 dto</param>
    public void FillEventField(EventMetadata metadata, EventDto dto);

    /// <summary>
    /// 이벤트 dto의 데이터를 기반으로 이벤트 정보를 갱신한다.
    /// </summary>
    /// <param name="metadata"></param>
    /// <param name="dto"></param>
    public void EditEventField(EventMetadata metadata, EventDto dto);

    /// <summary>
    /// 이벤트 엔티티 데이터로 이벤트 dto 정보를 채운다
    /// </summary>
    /// <param name="metadata">이벤트 객체</param>
    /// <param name="dto">이벤트 dto</param>
    public void FillEventDto(EventMetadata metadata, EventDto dto);
  }
}