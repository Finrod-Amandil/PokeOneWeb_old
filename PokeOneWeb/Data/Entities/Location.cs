using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// A Location is the smallest spatial entity in PokéOne. One Location can be as small as
    /// a single room in a building, but can go up to being an entire Route.
    /// </summary>
    public class Location
    {
        public int Id { get; set; }

        /// <summary>
        /// The display name for the lLcation
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Whether the Location is currently accessible (in any way). Player-specific
        /// restrictions such as insufficient progress in the story are not modelled by this field.
        /// Defaults to true.
        /// </summary>
        public bool IsAccessible { get; set; } = true;

        /// <summary>
        /// Whether first entering this Location adds one point to the ingame achievement linked to
        /// discovering as many locations as possible.
        /// </summary>
        public bool IsDiscoverable { get; set; }

        /// <summary>
        /// The <see cref="Entities.Region"/> this Location belongs to. A Location always belongs to exactly one
        /// region. <see cref="Event"/>-related Locations should always be linked to an Event Region.
        /// </summary>
        [ForeignKey("RegionId")]
        public Region Region { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.Region"/>.
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// The <see cref="Entities.LocationGroup"/> this Location belongs to. A Location always belongs to exactly one
        /// Location Group. Location Groups are used to group multiple locations together for a single page in the Web App.
        /// </summary>
        [ForeignKey("LocationGroupId")]
        public LocationGroup LocationGroup { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.LocationGroup"/>
        /// </summary>
        public int LocationGroupId { get; set; }

        /// <summary>
        /// A <see cref="PokemonSpeciesVariety"/> which is typical for this Location. Optional.
        /// </summary>
        [ForeignKey("SignificantPokemonSpeciesVarietyId")]
        public PokemonSpeciesVariety SignificantPokemonSpeciesVariety { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="PokemonSpeciesVariety"/>. May be null.
        /// </summary>
        public int? SignificantPokemonSpeciesVarietyId { get; set; }

        /// <summary>
        /// All <see cref="LocationInteraction"/>s found within this Location.
        /// </summary>
        public List<LocationInteraction> LocationInteractions { get; set; }

        /// <summary>
        /// All <see cref="Quest"/>s linked to this Location.
        /// </summary>
        public List<Quest> Quests { get; set; }
    }
}
