namespace domain.eventcommon.dto
{
  public class EventDto
  {
    /// <summary>
    /// 이벤트의 Id 값
    /// </summary>
    public string eventId { get; set; }

    /// <summary>
    /// 이벤트의 이름
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// 이벤트에 대한 설명
    /// </summary>
    public string description { get; set; }

    /// <summary>
    /// 이벤트 시작 시간. UTC 기준
    /// </summary>
    public DateTime startTime { get; set; }

    /// <summary>
    /// 이벤트 종료 시간. UTC 기준
    /// </summary>
    public DateTime endTime { get; set; }

    public string url { get; set; }

    /// <summary>
    /// 이벤트의 타입
    /// </summary>
    public EventType eventType { get; set; }


    /// <summary>
    /// 이벤트가 속한 프레임의 Id
    /// </summary>
    public string frameId { get; set; }
  }
}