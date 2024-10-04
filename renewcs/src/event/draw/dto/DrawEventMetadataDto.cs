using System.ComponentModel.DataAnnotations;

namespace domain.drawevent.dto
{
  public class DrawEventMetadataDto
  {
    /// <summary>
    /// 추첨 이벤트에 대한 id
    /// </summary>
    public long? Id { get; set; }

    /// <summary>
    /// 추첨 이벤트의 등수
    /// </summary>
    [Required]
    [Range(1, int.MaxValue)]
    public int grade { get; set; }

    /// <summary>
    /// 현재 등수의 최대 당첨자 수
    /// </summary>
    [Required]
    [Range(1, int.MaxValue)]
    public int count { get; set; }

    /// <summary>
    /// 현재 등수에 대한 상품 정보
    /// </summary>
    public string prizeInfo { get; set; } = string.Empty;
  }
}