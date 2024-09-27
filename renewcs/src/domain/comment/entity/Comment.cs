using System.ComponentModel.DataAnnotations.Schema;

namespace domain.comment {
  /// <summary>
  /// 이벤트에서 사용할 수 있는 댓글 객체
  /// </summary>
  public class Comment {
    [Column("id")]
    public long Id { get; set; }

  }
}