using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Spawn rarities are tiers to classify how rarely a <see cref="PokemonSpawn"/> occurs.
    /// </summary>
    [Table("SpawnRarity")]
    public class SpawnRarity
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The name for this tier.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Which <see cref="PokemonSpawn"/>s have this rarity.
        /// </summary>
        public ICollection<PokemonSpawn> PokemonSpawns { get; set; }
    }
}