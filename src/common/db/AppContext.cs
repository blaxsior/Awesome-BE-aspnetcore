using domain.eventframe;
using domain.eventmetadata;
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

    public DbSet<EventFrame> EventFrames { get; set; }
    public DbSet<EventMetadata> EventMetadatas { get; set; }
  }
}