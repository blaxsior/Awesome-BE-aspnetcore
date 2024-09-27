using common.jwt;

namespace common.config.inject {
  public class InjectConfig {
    // Singleton: 프로젝트 생명 주기에서 단 하나만 생성됨
    // Transcient: 요청할 때마다 생성
    // Scoped: 주입 위치마다 하나씩 생성. 주입 위치가 다르면 다른 객체
    public static void Config(WebApplicationBuilder builder) {
      builder.Services.AddSingleton<IJwtService, JwtService>();
    }
  }
}