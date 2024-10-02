using System.ComponentModel.DataAnnotations.Schema;
using domain.eventcommon;
using Microsoft.EntityFrameworkCore;

namespace domain.eventcommon.dto
{
  /// <summary>
  /// 이벤트 타입이 공유하는 정보
  /// </summary>
  [Index(nameof(FrameId), IsUnique = true)]
  public class EventFrame
  {
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// 이벤트 프레임의 이름
    /// </summary>
    [Column("name", TypeName = "varchar(50)")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 이벤트 프레임을 식별하는 ID 값
    /// </summary>
    [Column("FrameId", TypeName = "varchar(50)")]
    public string FrameId { get; set; } = string.Empty;

    /// <summary>
    /// 연결된 event 목록
    /// </summary>
    public IEnumerable<EventMetadata>? EventMetadata { get; set; }
  }
}