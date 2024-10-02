using System.ComponentModel.DataAnnotations.Schema;

namespace domain.shorturl
{
  /// <summary>
  /// 단축 URL
  /// </summary>
  public class ShortUrl
  {
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// 단축 URL이 만료되는 시간. UTC 시간 기준.
    /// </summary>
    [Column("expire_date")]
    public required DateTime expire_date;

    /// <summary>
    /// 단축된 URL
    /// </summary>
    [Column("hash", TypeName ="varchar(100)")]
    public required string Hash { get; set; }

    /// <summary>
    /// 원본 URL
    /// </summary>
    [Column("original_url", TypeName="varchar(255)")]
    public required string OriginalUrl { get; set; }
  }
}