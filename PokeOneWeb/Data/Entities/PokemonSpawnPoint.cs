using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using PokeOneWeb.Data.Entities.Enums;

namespace PokeOneWeb.Data.Entities
{
    public class PokemonSpawnPoint : LocationInteraction
    {
        [Column("PokemonSpawnPoint_Type")]
        public PokemonSpawnPointType Type { get; set; }
        public List<PokemonSpawn> PokemonSpawns { get; set; }
    }
}
