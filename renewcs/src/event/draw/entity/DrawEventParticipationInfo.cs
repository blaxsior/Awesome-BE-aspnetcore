using System.ComponentModel.DataAnnotations.Schema;
using domain.eventuser;

namespace domain.drawevent
{
  /// <summary>
  /// 추첨 이벤트 당첨 여부를 저장하는 엔티티
  /// </summary>
  public class DrawEventParticipationInfo
  {
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// 이벤트 참여 일자. UTC 날짜로 지정됨
    /// </summary>
    [Column("date")]
    public DateTime date { get; set; } = DateTime.UtcNow;


    /// <summary>
    /// 참여한 추첨 이벤트의 id
    /// </summary>
    [ForeignKey("DrawEvent")]
    [Column("draw_event_id")]
    public required long DrawEventId { get; set; }
    public virtual DrawEvent? DrawEvent { get; set; }

    /// <summary>
    /// 이벤트에 참여한 유저의 id
    /// </summary>
    [ForeignKey("EventUser")]
    [Column("event_user_id")]
    public required long EventUserId { get; set; }
    public virtual EventUser? EventUser { get; set; }
  }
}