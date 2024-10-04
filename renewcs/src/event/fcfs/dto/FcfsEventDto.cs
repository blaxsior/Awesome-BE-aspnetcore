using System.ComponentModel.DataAnnotations;

namespace domain.fcfsevent.dto
{
  public class FcfsEventDto
  {
    /// <summary>
    /// fcfs 이벤트의 id. 직접 설정 X
    /// </summary>
    public long? id { get; set; }

    /// <summary>
    /// 선착순 이벤트에 참여할 수 있는 사람 수
    /// </summary>
    [Range(1, int.MaxValue)]
    [Required]
    public int participantCount { get; set; }

    /// <summary>
    /// 선착순 이벤트의 시작 시간
    /// </summary>
    [Required]
    public DateTime startTime { get; set; }

    /// <summary>
    /// 선착순 이벤트의 종료 시간
    /// </summary>
    [Required]
    public DateTime endTime { get; set; }

    
    /// <summary>
    /// 현재 등수에 대한 상품 정보
    /// </summary>
    public string prizeInfo { get; set; } = string.Empty;
  }
}