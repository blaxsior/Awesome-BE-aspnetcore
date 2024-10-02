using domain.eventcommon.dto;
using util.query;

namespace domain.eventcommon.repository {
  public interface IEventFrameRepository {
    public Task<EventFrame?> FindByFrameIdAsync(string frameId);
  }
}