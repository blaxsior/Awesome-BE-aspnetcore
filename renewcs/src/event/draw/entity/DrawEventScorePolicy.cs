using System.ComponentModel.DataAnnotations.Schema;

namespace domain.drawevent
{
  /// <summary>
  /// 추첨 이벤트 액션에 대한 점수 배열을 표현하는 엔티티
  /// </summary>
  public class DrawEventScorePolicy
  {
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// 액션
    /// </summary>
    [Column("action", TypeName = "varchar(20)")]
    public virtual DrawEventAction Action { get; set; }

    /// <summary>
    /// 점수
    /// </summary>
    [Column("score")]
    public int Score { get; set; }

    /// <summary>
    /// 추첨 이벤트 id 값
    /// </summary>
    [ForeignKey("DrawEvent")]
    [Column("draw_event_id")]
    public long DrawEventId { get; set; }
    public virtual DrawEvent? DrawEvent { get; set; }
  }
}