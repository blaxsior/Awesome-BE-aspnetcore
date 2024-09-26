
using System.ComponentModel.DataAnnotations.Schema;

namespace domain.drawevent
{
  /// <summary>
  /// 추첨 이벤트의 등수 별 상품 정보를 저장하는 엔티티
  /// </summary>
  public class DrawEventMetadata
  {
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// 등수
    /// </summary>
    [Column("grade")]
    public int Grade { get; set; }

    /// <summary>
    /// 등수 별 당첨자 수
    /// </summary>
    [Column("count")]
    public int Count { get; set; }

    /// <summary>
    /// 현재 등수에 대한 상품 정보
    /// </summary>
    [Column("prize_info")]
    public string PrizeInfo { get; set; } = string.Empty;

    /// <summary>
    /// 추첨 이벤트를 가리키는 키
    /// </summary>
    [ForeignKey("DrawEvent")]
    [Column("draw_event_id")]
    public required long DrawEventId { get; set; }
    public DrawEvent? DrawEvent { get; set; }
  }
}