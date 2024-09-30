using System.ComponentModel.DataAnnotations.Schema;
using domain.eventframe;

namespace domain.comment
{
  /// <summary>
  /// 이벤트에서 사용할 수 있는 댓글 객체
  /// </summary>
  public class Comment
  {
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// 댓글 내용
    /// </summary>
    [Column("content", TypeName = "varchar(100)")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// 댓글 작성일
    /// </summary>
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// 댓글을 작성한 이벤트 프레임
    /// </summary>
    [ForeignKey("EventFrame")]
    [Column("event_frame_id")]
    public required long EventFrameId { get; set; }
    public EventFrame? EventFrame { get; set; }

    /// <summary>
    /// 댓글을 작성한 이벤트 유저의 id
    /// </summary>
    [ForeignKey("EventUser")]
    [Column("event_user_id")]
    public required long EventUserId { get; set; }
  }
}