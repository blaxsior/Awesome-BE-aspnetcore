using System.Text.Json.Serialization;

namespace domain.drawevent {
  /// <summary>
  /// 추첨 이벤트 액션을 표현하는 열거형
  /// </summary>
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum DrawEventAction {
    WriteComment,
    ParticipateEvent
  }
}