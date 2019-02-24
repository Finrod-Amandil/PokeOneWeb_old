using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// A <see cref="Pokemon"/> is a specific specimen of a <see cref="Entities.PokemonSpeciesVariety"/>.
    /// </summary>
    [Table("Pokemon")]
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The level this Pokémon has. May exceed the usual cap of Lv. 100.
        /// </summary>
        [Column("Level")]
        public int Level { get; set; }

        /// <summary>
        /// Used for <see cref="Pokemon"/> as <see cref="BossPokemon"/>. Specifies whether
        /// the level of this Pokémon increments every time it is being challenged.
        /// </summary>
        public bool DoesLevelIncrease { get; set; }

        /// <summary>
        /// Used for <see cref="Pokemon"/> as <see cref="BossPokemon"/> and <see cref="TrainerPokemon"/>. If the level
        /// constantly increases, this field specifies which level the Pokémon can reach at most. May exceed the usual
        /// cap of Lv. 100.
        /// </summary>
        public int MaxLevel { get; set; }

        /// <summary>
        /// Whether this Pokémon can be caught.
        /// </summary>
        public bool IsCatchable { get; set; }
        
        /// <summary>
        /// Of which <see cref="Entities.PokemonSpeciesVariety"/> this Pokémon is a specimen of.
        /// </summary>
        [ForeignKey("PokemonSpeciesVarietyId")]
        public PokemonSpeciesVariety PokemonSpeciesVariety { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.PokemonSpeciesVariety"/>
        /// </summary>
        public int PokemonSpeciesVarietyId { get; set; }

        /// <summary>
        /// Which <see cref="Entities.Ability"/> this Pokémon has, out of the pool that is available to this <see cref="Entities.PokemonSpeciesVariety"/>
        /// </summary>
        [ForeignKey("AbilityId")]
        public Ability Ability { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.Ability"/>
        /// </summary>
        public int AbilityId { get; set; }

        /// <summary>
        /// Optional one-to-one relation to a PokemonNpc representing this Pokemon in the game world.
        /// </summary>
        public PokemonNpc PokemonNpc { get; set; }

        /// <summary>
        /// Which moves this Pokémon currently knows.
        /// </summary>
        public ICollection<PokemonMove> PokemonMoves { get; set; }

        /// <summary>
        /// Which <see cref="Item"/>s this Pokémon drops if it is defeated.
        /// </summary>
        public ICollection<PokemonDropItem> PokemonDropItems { get; set; }
    }
}
