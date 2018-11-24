using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class PokemonSpawnTimeOfDay
    {
        public int Id { get; set; }

        [ForeignKey("PokemonSpawnId")]
        public PokemonSpawn PokemonSpawn { get; set; }
        public int PokemonSpawnId { get; set; }

        [ForeignKey("TimeOfDayId")]
        public TimeOfDay TimeOfDay { get; set; }
        public int TimeOfDayId { get; set; }
    }
}
