using domain.comment;
using domain.drawevent;
using domain.eventframe;
using domain.eventmetadata;
using domain.eventuser;
using domain.fcfsevent;
using domain.shorturl;
using Microsoft.EntityFrameworkCore;

namespace common.db
{
  /// <summary>
  /// DB Context를 정의하는 클래스
  /// </summary>
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    /* 이벤트 공통 */
    public DbSet<EventFrame> EventFrames { get; set; }
    public DbSet<EventMetadata> EventMetadatas { get; set; }

    /* 선착순 이벤트 */
    public DbSet<FcfsEvent> FcfsEvents { get; set; }
    public DbSet<FcfsEventWinningInfo> FcfsEventWinningInfos { get; set; }

    /* 추첨 이벤트 */
    public DbSet<DrawEvent> DrawEvents { get; set; }
    public DbSet<DrawEventMetadata> DrawEventMetadatas { get; set; }
    public DbSet<DrawEventScorePolicy> DrawEventScorePolicies { get; set; }
    public DbSet<DrawEventParticipationInfo> DrawEventParticipationInfos { get; set; }
    public DbSet<DrawEventWinningInfo> DrawEventWinningInfos { get; set; }

    /* 이벤트 유저 */
    public DbSet<EventUser> EventUsers { get; set; }

    /* 댓글 */
    public DbSet<Comment> Comments{ get; set; }

    /* 단축 URL */
    public DbSet<ShortUrl> ShortUrls { get; set; }
  }
}