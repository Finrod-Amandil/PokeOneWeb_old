using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class Location
    {
        public Location()
        {
            IsAccessible = true;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAccessible { get; set; }
        public bool IsDiscoverable { get; set; }

        [ForeignKey("RegionId")]
        public Region Region { get; set; }
        public int RegionId { get; set; }

        [ForeignKey("LocationGroupId")]
        public LocationGroup LocationGroup { get; set; }
        public int LocationGroupId { get; set; }

        [ForeignKey("SignificantPokemonSpeciesVarietyId")]
        public PokemonSpeciesVariety SignificantPokemonSpeciesVariety { get; set; }
        public int SignificantPokemonSpeciesVarietyId { get; set; }

        public List<LocationInteraction> LocationInteractions { get; set; }
        public List<Quest> Quests { get; set; }
    }
}
