using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Sometimes the player may get a Pokémon without any compensation. This is modeled with this entity.
    /// A <see cref="PokemonNpc"/> may deliberately join the player's team, which then is also modeled with
    /// this entity.
    /// </summary>
    [Table("PokemonGift")]
    public class PokemonGift
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Which <see cref="Entities.Npc"/> gifts the Pokémon.
        /// </summary>
        [ForeignKey("NpcId")]
        public Npc Npc { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.Npc"/>.
        /// </summary>
        public int NpcId { get; set; }

        /// <summary>
        /// Which <see cref="Entities.PokemonSpeciesVariety"/> is being gifted.
        /// </summary>
        [ForeignKey("PokemonSpeciesVarietyId")]
        public PokemonSpeciesVariety PokemonSpeciesVariety { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.PokemonSpeciesVariety"/>.
        /// </summary>
        public int PokemonSpeciesVarietyId { get; set; }
    }
}
