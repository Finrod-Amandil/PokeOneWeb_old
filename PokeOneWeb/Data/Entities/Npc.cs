using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    /// <inheritdoc />
    /// <summary>
    /// Abstract base class for all NPCs for polymorphism.
    /// </summary>
    public abstract class Npc : LocationInteraction
    {
        /// <summary>
        /// Which items this NPC can give as gift.
        /// </summary>
        public ICollection<ItemGift> ItemGifts { get; set; }

        /// <summary>
        /// Which Pokémon this NPC can give as gift. A <see cref="PokemonNpc"/> may join the player's
        /// team deliberately, thus "gifting himself".
        /// </summary>
        public ICollection<PokemonGift> PokemonGifts { get; set; }
    }
}
