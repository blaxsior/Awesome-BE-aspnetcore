using System.ComponentModel.DataAnnotations;

namespace domain.drawevent.dto {
  public class DrawEventDto {
    /// <summary>
    /// 정책 목록
    /// </summary>
    [Required]
    public List<DrawEventScorePolicyDto> policies { get; set; } = [];

    /// <summary>
    /// 당첨 관련 정보(등수, 인원, 상품 등)
    /// </summary>
    [Required]
    public List<DrawEventMetadataDto> metadata { get; set; } = [];
  }
}