using common.jwt;
using domain.eventmetadata.service;

namespace common.config.inject {
  public class InjectConfig {
    // Singleton: 프로젝트 생명 주기에서 단 하나만 생성하고 모든 요청에서 재사용
    // Scoped: 인스턴스를 하나의 요청에 대해 만들고 재사용
    // Transcient: 인스턴스가 하나의 요청 내에서도 매번 새롭게 생성
    public static void Config(WebApplicationBuilder builder) {
      // JWT
      builder.Services.AddSingleton<IJwtService, JwtService>();

      // Service
      builder.Services.AddScoped<IEventService, EventService>();
    }
  }
}