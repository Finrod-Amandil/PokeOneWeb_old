using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// The Region entity models an ingame region. Regions are the largest spatial entity of PokéOne
    /// and consist of many <see cref="Location"/>s. All Locations which are bound to a specific <see cref="Entities.Event"/>
    /// are collected within an Event Region.
    /// </summary>
    public class Region
    {
        public int Id { get; set; }

        /// <summary>
        /// Display name for this Region.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// All <see cref="Location"/>s this Region consists of.
        /// </summary>
        public ICollection<Location> Locations { get; set; }

        /// <summary>
        /// Whether this is a 'regular' Region which is always accessible or
        /// a temporary <see cref="Entities.Event"/> Region.
        /// </summary>
        public bool IsEventRegion { get; set; } = false;

        /// <summary>
        /// The <see cref="Entities.Event"/> this Region belongs to. Only set if Region is an Event Region.
        /// </summary>
        [ForeignKey("EventId")]
        public Event Event { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.Event"/>. Null if the Region is not an Event Region.
        /// </summary>
        public int? EventId { get; set; }
    }
}
