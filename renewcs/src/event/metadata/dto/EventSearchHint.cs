namespace domain.eventmetadata.dto {
  /// <summary>
  /// 관리자가 이벤트 댓글 검색 시 자동완성에 제공되는 데이터
  /// </summary>
  public class EventSearchHintDto {
    /// <summary>
    /// 이벤트의 식별자. HD000000_000 꼴로 표현됨
    /// </summary>
    public required string EventId { get; set; }

    /// <summary>
    /// 이벤트의 이름
    /// </summary>
    public required string EventName { get; set; }
  }
}