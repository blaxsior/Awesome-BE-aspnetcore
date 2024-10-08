using common.jwt;
using domain.eventcommon;
using domain.eventcommon.component;
using domain.eventcommon.repository;
using domain.eventcommon.service;

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

      // EventFieldMappers
  
      builder.Services.AddKeyedScoped<IEventFieldMapper, FcfsEventFieldMapper>(EventType.fcfs);
      builder.Services.AddKeyedScoped<IEventFieldMapper, DrawEventFieldMapper>(EventType.draw);
      builder.Services.AddScoped<Dictionary<EventType, IEventFieldMapper>>(it => {
        return new Dictionary<EventType, IEventFieldMapper> {
          { EventType.fcfs, it.GetKeyedService<IEventFieldMapper>(EventType.fcfs)! },
          { EventType.draw, it.GetKeyedService<IEventFieldMapper>(EventType.draw)! },
        };
      });
      builder.Services.AddScoped<EventFieldMapperMatcher>();

      // repositories
      builder.Services.AddScoped<IEventMetadataRepository, EventMetadataRepository>();
      builder.Services.AddScoped<IEventFrameRepository, EventFrameRepository>();
    }
  }
}