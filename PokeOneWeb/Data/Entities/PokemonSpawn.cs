using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PokeOneWeb.Data.Entities.Enums;

namespace PokeOneWeb.Data.Entities
{
    public class PokemonSpawn
    {
        public int Id { get; set; }
        public SpawnRarity SpawnRarity { get; set; }
        public bool Verified { get; set; }

        [ForeignKey("PokemonSpeciesId")]
        public PokemonSpecies PokemonSpecies { get; set; }
        public int PokemonSpeciesId { get; set; }

        public List<PokemonSpawnTimeOfDay> TimesOfDay { get; set; }

        [ForeignKey("PokemonSpawnPointId")]
        public PokemonSpawnPoint PokemonSpawnPoint { get; set; }
        public int PokemonSpawnPointId { get; set; }
    }
}
