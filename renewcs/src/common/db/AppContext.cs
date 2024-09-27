using domain.drawevent;
using domain.eventframe;
using domain.eventmetadata;
using domain.fcfsevent;
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
    /* 추첨 이벤트 */
    public DbSet<DrawEvent> DrawEvents { get; set; }
    public DbSet<DrawEventMetadata> DrawEventMetadatas { get; set; }
    public DbSet<DrawEventScorePolicy> DrawEventScorePolicies { get; set; }
  }
}