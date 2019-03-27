using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// A Map entity represents an in-game map, which is presented on a <see cref="Entities.LocationGroup"/>'s page. A Map
    /// may display multiple in-game locations at once.
    /// </summary>
    [Table("Map")]
    public class Map
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The display name for this Map which describes all the <see cref="MapLocation"/>s within the map.
        /// </summary>
        public string Name { get; set; }

        public int MaxZoomLevel { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }

        /// <summary>
        /// Which <see cref="Location"/>s are placed on this map, with the additional information of their
        /// relative placement.
        /// </summary>
        public ICollection<MapLocation> MapLocations { get; set; }

        /// <summary>
        /// The <see cref="Entities.LocationGroup"/> this Map belongs to.
        /// </summary>
        public LocationGroup LocationGroup { get; set; }
    }
}