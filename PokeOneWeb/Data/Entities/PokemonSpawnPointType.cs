using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Classifies <see cref="PokemonSpawnPoint"/>s.
    /// </summary>
    [Table("PokemonSpawnPointType")]
    public class PokemonSpawnPointType
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The display name for this type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Which spawn points there are of this type.
        /// </summary>
        public ICollection<PokemonSpawnPoint> PokemonSpawnPoints { get; set; }
    }
}
