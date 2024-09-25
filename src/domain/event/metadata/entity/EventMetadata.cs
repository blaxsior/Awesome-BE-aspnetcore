using System.ComponentModel.DataAnnotations.Schema;
using domain.drawevent;
using domain.eventframe;
using domain.fcfsevent;
using Microsoft.EntityFrameworkCore;

namespace domain.eventmetadata
{
  /// <summary>
  /// 이벤트 타입이 공유하는 정보
  /// </summary>
  [Index(nameof(EventId), IsUnique = true)]
  public class EventMetadata
  {
    [Column("id")]
    public uint Id { get; set; }

    /// <summary>
    /// 이벤트가 시작하는 시간. UTC 기준
    /// </summary>
    [Column("start_time")]
    public DateTime StartTime { get; set; }

    /// <summary>
    /// 이벤트가 종료되는 시간. UTC 기준
    /// </summary>
    [Column("end_time")]
    public DateTime EndTime { get; set; }

    /// <summary>
    /// 이벤트의 이름
    /// </summary>
    [Column("name", TypeName = "varchar(40)")]
    public string name { get; set; } = string.Empty;

    /// <summary>
    /// 이벤트에 대한 설명
    /// </summary>
    [Column("description", TypeName = "varchar(100)")]
    public string description { get; set; } = string.Empty;

    /// <summary>
    /// 이벤트의 식별 키. HDYYMMDD_00X 형식으로 표현
    /// </summary>
    [Column("event_id", TypeName = "varchar(14)")]
    public string EventId { get; set; } = string.Empty;

    /// <summary>
    /// 이벤트 페이지의 url
    /// </summary>
    [Column("url", TypeName = "varchar(255)")]
    public string url { get; set; } = string.Empty;

    /// <summary>
    /// 이벤트의 타입
    /// </summary>
    [Column("event_type")]
    public EventType EventType { get; set; }

    /// <summary>
    /// 현재 이벤트와 연관된 이벤트 프레임의 id
    /// </summary>
    [ForeignKey("EventFrame")]
    [Column("event_frame_id")]
    public required int EventFrameId { get; set; }
    /// <summary>
    /// 현재 이벤트와 연관된 이벤트 프레임
    /// </summary>
    public EventFrame? EventFrame { get; set; }

    /* 연관 이벤트 정의*/

    public List<FcfsEvent>? FcfsEvents { get; set; }
    public DrawEvent? DrawEvent { get; set; }
  }
}