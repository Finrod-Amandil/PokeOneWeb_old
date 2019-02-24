using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <inheritdoc />
    /// <summary>
    /// A Portal describes a possibility to change from one Location to another. Note that
    /// each 'logical' Portal exists twice - once per Location connected.
    /// </summary>
    public class Portal : LocationInteraction
    {
        /// <summary>
        /// Optional label for the Portal. Can be used to associate two connected Portals on a
        /// multi-location Map with many Portals, such as caves or buildings.
        /// </summary>
        [Column("Portal_Label")]
        public string Label { get; set; }

        /// <summary>
        /// The target location to which this Portal leads. The origin Location is given by
        /// the location of this entity which is a subclass of <see cref="LocationInteraction"/>.
        /// </summary>
        [ForeignKey("TargetLocationId")]
        public Location TargetLocation { get; set; }

        /// <summary>
        /// Foreign key for the target Location.
        /// </summary>
        [Column("Portal_TargetLocationId")]
        public int TargetLocationId { get; set; }
    }
}
