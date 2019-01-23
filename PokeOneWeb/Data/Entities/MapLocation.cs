using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Describes the map of a single location, which is part of a <see cref="Entities.Map"/>
    /// entity which may encompass multiple Locations' maps.
    /// </summary>
    public class MapLocation
    {
        public int Id { get; set; }

        /// <summary>
        /// The <see cref="Entities.Map"/> this Location's map is placed on.
        /// </summary>
        [ForeignKey("MapId")]
        public Map Map { get; set; }

        /// <summary>
        /// Foreign key for the Map.
        /// </summary>
        public int MapId { get; set; }

        /// <summary>
        /// The <see cref="Entities.Location"/> this MapLocation represents.
        /// </summary>
        [ForeignKey("LocationId")]
        public Location Location { get; set; }

        /// <summary>
        /// Foreign key for the Location
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// The relative placement of this location's map on the encompassing <see cref="Entities.Map"/> entity.
        /// </summary>
        //TODO: Data type TBD
        public object Placement { get; set; }
    }
}