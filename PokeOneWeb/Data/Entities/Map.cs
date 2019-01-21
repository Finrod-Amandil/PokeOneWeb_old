using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// A Map entity represents an ingame map, which is presented on a <see cref="Entities.LocationGroup"/>'s page. A Map
    /// may display multiple ingame locations at once.
    /// </summary>
    public class Map
    {
        public int Id { get; set; }

        /// <summary>
        /// The display name for this Map which describes all the <see cref="MapLocation"/>s within the map.
        /// </summary>
        public string Name { get; set; }

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