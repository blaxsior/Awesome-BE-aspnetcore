using System.ComponentModel.DataAnnotations;

namespace domain.drawevent.dto {
  public class DrawEventScorePolicyDto {
    public long? id { get; set; }

    /// <summary>
    /// 액션
    /// </summary>
    [Required]
    public DrawEventAction action { get; set; }

    /// <summary>
    /// 점수
    /// </summary>
    [Required]
    [Range(1, int.MaxValue)]
    public int score { get; set; }
  }
}