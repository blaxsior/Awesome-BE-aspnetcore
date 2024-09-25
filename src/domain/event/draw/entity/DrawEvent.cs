using System.ComponentModel.DataAnnotations.Schema;
using domain.eventmetadata;

namespace domain.drawevent {
  public class DrawEvent {
    [Column("id")]
    public uint Id { get; set; }

    [ForeignKey("EventMetadata")]
    [Column("event_metadata_id")]
    public required uint EventMetadataId { get; set; }

    public EventMetadata? EventMetadata { get; set; }
  }
}