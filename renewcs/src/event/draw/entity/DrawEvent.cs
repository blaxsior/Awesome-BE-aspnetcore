using System.ComponentModel.DataAnnotations.Schema;
using domain.eventcommon;

namespace domain.drawevent {
  /// <summary>
  /// 추첨 이벤트를 의미하는 엔티티
  /// </summary>
  public class DrawEvent {
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// 현재 이벤트가 추첨되었는지 상태를 표현하는 필드
    /// </summary>
    [Column("is_drawn")]
    public bool IsDrawn { get; set; } = false;

    /// <summary>
    /// 이벤트 메타데이터의 id 값
    /// </summary>
    [ForeignKey("EventMetadata")]
    [Column("event_metadata_id")]
    public required long EventMetadataId { get; set; }
    public EventMetadata? EventMetadata { get; set; }
  }
}