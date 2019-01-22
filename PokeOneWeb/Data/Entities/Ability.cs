using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Abilites grant <see cref="Pokemon"/> various special effects during and/or outside of battles.
    /// Every Pokémon has exactly one ability, but a <see cref="PokemonSpeciesVariety"/> may have a pool
    /// of multiple abilities to choose from.
    /// </summary>
    public class Ability
    {
        public int Id { get; set; }

        /// <summary>
        /// The display name for the ability
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the effect of the ability
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Which PokémonSpeciesVarieties can obtain this ability.
        /// </summary>
        public ICollection<PokemonSpeciesVariety> PokemonSpeciesVarieties { get; set; }
    }
}
