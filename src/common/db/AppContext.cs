using Microsoft.EntityFrameworkCore;

namespace common.db {
  public class AppDbContext: DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {

    }
  }
}