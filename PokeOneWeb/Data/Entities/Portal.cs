using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class Portal : LocationInteraction
    {
        [ForeignKey("TargetLocationId")]
        public Location Target { get; set; }
        [Column("Portal_TargetId")]
        public int TargetLocationId { get; set; }
    }
}
