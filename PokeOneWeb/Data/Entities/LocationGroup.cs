using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// A Location Group groups together all locations which are to be displayed on the same web page.
    /// </summary>
    [Table("LocationGroup")]
    public class LocationGroup
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The technical name for the Location Group. This name is used to generate a URL for this Location Group's page and thus needs
        /// to be unique. Uniqueness is enforced by EF Core, see <see cref="ApplicationDbContext"/> for the setup code.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name for the Location Group as it can be displayed.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Which <see cref="Map"/>s are presented on this LocationGroup's page.
        /// </summary>
        public ICollection<Map> Maps { get; set; }

        /// <summary>
        /// Which <see cref="Location"/>s this Location Group consists of. Every Location belongs to exactly one Location Group.
        /// </summary>
        public ICollection<Location> Locations { get; set; }
    }
}