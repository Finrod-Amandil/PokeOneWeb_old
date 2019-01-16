using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class Pokemon
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public bool DoesLevelIncrease { get; set; }
        public bool isCatchable { get; set; }
        public int MaxLevel { get; set; }


        [ForeignKey("PokemonSpeciesVarietyId")]
        public PokemonSpeciesVariety PokemonSpeciesVariety { get; set; }
        public int PokemonSpeciesVarietyId { get; set; }

        [ForeignKey("AbilityId")]
        public Ability Ability { get; set; }
        public int AbilityId { get; set; }

        public List<PokemonMove> Moves { get; set; }
        public List<PokemonDropItem> Drops { get; set; }
    }
}
