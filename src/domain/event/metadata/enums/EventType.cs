namespace domain.eventmetadata {
  /// <summary>
  /// 현재 존재하는 이벤트 타입을 정의하는 열거형
  /// </summary>
  public enum EventType {
    /// <summary>
    /// 선착순 이벤트
    /// </summary>
    FCFS,
    /// <summary>
    /// 추첨 이벤트
    /// </summary>
    DRAW
  }
}