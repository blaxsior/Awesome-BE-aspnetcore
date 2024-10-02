namespace domain.eventcommon.dto
{
  /// <summary>
  /// 이벤트에 대한 간단한 정보를 포함하는 dto
  /// </summary>
  public class BriefEventDto
  {
    /// <summary>
    /// HD000000_000 형식으로 구성된 이벤트 식별자 ID
    /// </summary>
    public required string EventId { get; set; }

    /// <summary>
    /// 이벤트의 이름
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 이벤트의 시작 시간
    /// </summary>    
    public required DateTime StartTime { get; set; }

    /// <summary>
    /// 이벤트의 종료 시간
    /// </summary>    
    public required DateTime EndTime { get; set; }

    /// <summary>
    /// 이벤트의 타입
    /// </summary>
    public required EventType EventType { get; set; }
  }
}