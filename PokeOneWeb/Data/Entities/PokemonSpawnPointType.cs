using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Classifies <see cref="PokemonSpawnPoint"/>s.
    /// </summary>
    public class PokemonSpawnPointType
    {
        public int Id { get; set; }

        /// <summary>
        /// The display name for this type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Which Spawnpoints there are of this type.
        /// </summary>
        public ICollection<PokemonSpawnPoint> PokemonSpawnPoints { get; set; }
    }
}
