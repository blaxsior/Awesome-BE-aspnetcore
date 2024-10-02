using System.ComponentModel.DataAnnotations.Schema;
using domain.eventcommon;
using domain.eventuser;

namespace domain.fcfsevent
{
  /// <summary>
  /// 선착순 이벤트 당첨 정보를 의미하는 엔티티
  /// </summary>
  public class FcfsEventWinningInfo
  {
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// 이벤트 당첨 시간
    /// </summary>
    [Column("date")]
    public DateTime Date { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// 이벤트 유저의 id
    /// </summary>
    [ForeignKey("EventUser")]
    [Column("event_user_id")]
    public required long EventUserId { get; set; }
    public EventUser? EventUser { get; set; }

    /// <summary>
    /// 선착순 이벤트의 id
    /// </summary>
    [ForeignKey("FcfsEvent")]
    [Column("fcfs_event_id")]
    public required long FcfsEventId { get; set; }
    public FcfsEvent? FcfsEvent { get; set; }
  }
}