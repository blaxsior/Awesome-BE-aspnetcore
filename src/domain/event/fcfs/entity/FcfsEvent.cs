using System.ComponentModel.DataAnnotations.Schema;
using domain.eventmetadata;

namespace domain.fcfsevent
{
  /// <summary>
  /// 단일 선착순 이벤트를 의미하는 엔티티
  /// </summary>
  public class FcfsEvent
  {
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// 선착순 이벤트에 참여할 수 있는 사람 수
    /// </summary>
    [Column("participant_count")]
    public int ParticipantCount { get; set; }

    /// <summary>
    /// 선착순 이벤트의 시작 시간. UTC 시간으로 처리
    /// </summary>
    [Column("start_time")]
    public DateTime StartTime { get; set; }

    /// <summary>
    /// 선착순 이벤트의 종료 시간. UTC 시간으로 처리
    /// </summary>
    [Column("end_time")]
    public DateTime EndTime { get; set; }

    /// <summary>
    /// 이벤트 메타데이터 id 값
    /// </summary>
    [ForeignKey("EventMetadata")]
    [Column("event_metadata_id")]
    public required long EventMetadataId { get; set; }
    public EventMetadata? EventMetadata { get; set; }
  }
}