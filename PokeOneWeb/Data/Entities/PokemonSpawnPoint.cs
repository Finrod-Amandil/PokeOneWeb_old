using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class PokemonSpawnPoint : LocationInteraction
    {
        [ForeignKey("SpawnPointTypeId")]
        public PokemonSpawnPointType SpawnPointType { get; set; }
        [Column("PokemonSpawnPoint_SpawnPointTypeId")]
        public int SpawnPointTypeId { get; set; }

        public List<PokemonSpawn> PokemonSpawns { get; set; }
    }
}
