using domain.eventcommon.dto;

namespace domain.eventcommon.repository {
  public interface IEventFrameRepository {
    public Task<EventFrame?> FindByFrameIdAsync(string frameId);
  }
}