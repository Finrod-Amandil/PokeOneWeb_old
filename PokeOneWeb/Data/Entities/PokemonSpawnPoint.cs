using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <inheritdoc />
    /// <summary>
    /// PokemonSpawnPoints are any 'thing' on a Location which are able to spawn a Wild Pokémon, with the exception
    /// of static <see cref="T:PokeOneWeb.Data.Entities.PokemonNpc" />. This can be grass patches, headbutt spots or just the entire floor of a
    /// cave. For multiple grass patches only one PokemonSpawnPoint should be specified which then applies to the
    /// entire location. Placement information can be omitted. Headbutt spots and Rock Smash Rocks should get one 
    /// Entity for each spot / rock in order to be able to specify their exact placement.
    /// </summary>
    public class PokemonSpawnPoint : LocationInteraction
    {
        /// <summary>
        /// Which type of spawn point this is.
        /// </summary>
        [ForeignKey("PokemonSpawnPointTypeId")]
        public PokemonSpawnPointType PokemonSpawnPointType { get; set; }

        /// <summary>
        /// Foreign key for the SpawnPointType.
        /// </summary>
        [Column("PokemonSpawnPoint_PokemonSpawnPointTypeId")]
        public int PokemonSpawnPointTypeId { get; set; }

        /// <summary>
        /// Which <see cref="PokemonSpawn"/>s this SpawnPoint can yield.
        /// </summary>
        public ICollection<PokemonSpawn> PokemonSpawns { get; set; }
    }
}
