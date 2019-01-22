using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// PokemonNpcs are interactable (no wild Pokémon spawns!) Pokémon, especially
    /// legendary Pokémon.
    /// </summary>
    public class PokemonNpc : Npc
    {
        /// <summary>
        /// The <see cref="Entities.Pokemon"/> entity describing the battle-specifics of the Pokemon behind the NPC (including the species).
        /// </summary>
        [ForeignKey("PokemonId")]
        public Pokemon Pokemon { get; set; }

        /// <summary>
        /// Foreign key for the Pokemon.
        /// </summary>
        [Column("PokemonNpc_PokemonId")]
        public int PokemonId { get; set; }

        /// <summary>
        /// What type of PokemonNpc this is.
        /// </summary>
        [ForeignKey("PokemonNpcTypeId")]
        public PokemonNpcType PokemonNpcType { get; set; }

        /// <summary>
        /// Foreign key for the PokemonNpcType.
        /// </summary>
        [Column("PokemonNpc_PokemonNpcTypeId")]
        public int PokemonNpcTypeId { get; set; }
    }
}
