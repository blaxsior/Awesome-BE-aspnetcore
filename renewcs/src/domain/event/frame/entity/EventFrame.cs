using System.ComponentModel.DataAnnotations.Schema;
using domain.eventmetadata;
using Microsoft.EntityFrameworkCore;

namespace domain.eventframe
{
  /// <summary>
  /// 이벤트 타입이 공유하는 정보
  /// </summary>
  [Index(nameof(Name), IsUnique = true)]
  public class EventFrame
  {
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// 이벤트 프레임의 이름
    /// </summary>
    [Column("name", TypeName = "varchar(20)")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 이벤트 프레임에 대한 설명
    /// </summary>
    [Column("description", TypeName = "varchar(100)")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// 연결된 event 목록
    /// </summary>
    public IEnumerable<EventMetadata>? EventMetadata { get; set; }
  }
}