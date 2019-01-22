using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Classifies <see cref="PokemonNpc"/>s.
    /// </summary>
    public class PokemonNpcType
    {
        public int Id { get; set; }

        /// <summary>
        /// The display name of this type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Which PokemonNpcs are of this type.
        /// </summary>
        public ICollection<PokemonNpc> PokemonNpcs { get; set; }
    }
}