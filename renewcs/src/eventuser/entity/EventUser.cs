using System.ComponentModel.DataAnnotations.Schema;
using domain.eventcommon;
using Microsoft.EntityFrameworkCore;

namespace domain.eventuser {
  /// <summary>
  /// 이벤트 유저를 의미하는 엔티티
  /// </summary>
  [Index("UserId", IsUnique = true)]
  public class EventUser {
    [Column("id")]
    public long Id {get; set;}

    /// <summary>
    /// 이벤트 유저에게 부여되는 아이디 값
    /// </summary>
    [Column("user_id", TypeName ="varchar(50)")]
    public long UserId {get; set;}

    /// <summary>
    /// 이벤트 유저의 전화번호
    /// </summary>
    [Column("phone_number", TypeName = " varchar(30)")]
    public string PhoneNumber {get; set;} = string.Empty;

    /// <summary>
    /// 이벤트 유저의 이름
    /// </summary>
    [Column("user_name", TypeName = "varchar(30)")]
    public string UserName {get; set;} = string.Empty;
    
    /// <summary>
    /// 이벤트 유저가 속한 프레임 정보
    /// </summary>
    [ForeignKey("EventFrame")]
    [Column("event_frame_id")]
    public required long EventFrameId {get; set;}
    public virtual EventFrame? EventFrame {get; set;}
  }
}