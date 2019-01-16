using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class Portal : LocationInteraction
    {
        public string Label { get; set; }

        [ForeignKey("TargetLocationId")]
        public Location Target { get; set; }
        [Column("Portal_TargetLocationId")]
        public int TargetLocationId { get; set; }
    }
}
