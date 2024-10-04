using System.Text.Json.Serialization;

namespace domain.eventcommon {
  /// <summary>
  /// 현재 존재하는 이벤트 타입을 정의하는 열거형
  /// </summary>
  [JsonConverter(typeof(JsonStringEnumConverter))]
  // Converter 정의되어 있어야 문자열로 처리해줌
  // https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/customize-properties?pivots=dotnet-8-0#enums-as-strings
  public enum EventType {
    /// <summary>
    /// 선착순 이벤트
    /// </summary>
    fcfs,
    /// <summary>
    /// 추첨 이벤트
    /// </summary>
    draw
  }
}