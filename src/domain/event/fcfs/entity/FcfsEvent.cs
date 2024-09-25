using System.ComponentModel.DataAnnotations.Schema;
using domain.eventmetadata;

namespace domain.fcfsevent
{
  public class FcfsEvent
  {
    [Column("id")]
    public uint Id { get; set; }

    [Column("participant_count")]
    public int ParticipantCount { get; set; }

    [Column("start_time")]
    public DateTime StartTime { get; set; }

    [Column("end_time")]
    public DateTime EndTime { get; set; }

    [ForeignKey("EventMetadata")]
    [Column("event_metadata_id")]
    public required uint EventMetadataId { get; set; }
    public EventMetadata? EventMetadata { get; set; }
  }
}