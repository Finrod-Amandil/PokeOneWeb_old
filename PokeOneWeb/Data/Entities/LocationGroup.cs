using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// A Location Group groups together all locations which are to be displayed on the same web page.
    /// </summary>
    public class LocationGroup
    {
        public int Id { get; set; }

        /// <summary>
        /// The display name for the Location Group. This name is used to generate a URL for this Location Group's page and thus needs
        /// to be unique.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Which <see cref="Map"/>s are presented on this Location Groups's page.
        /// </summary>
        public ICollection<Map> Maps { get; set; }

        /// <summary>
        /// Which <see cref="Location"/>s this Location Group consists of. Every Location belongs to exactly one Location Group.
        /// </summary>
        public ICollection<Location> Locations { get; set; }
    }
}