using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Transformation entity between <see cref="Entities.PokemonSpawn"/> and
    /// <see cref="Entities.TimeOfDay"/>. Required as a Spawn may be valid during multiple
    /// day times.
    /// </summary>
    [Table("PokemonSpawnTimeOfDay")]
    public class PokemonSpawnTimeOfDay
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The <see cref="Entities.PokemonSpawn"/> that may take place during this time of day.
        /// </summary>
        [ForeignKey("PokemonSpawnId")]
        public PokemonSpawn PokemonSpawn { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.PokemonSpawn"/>.
        /// </summary>
        public int PokemonSpawnId { get; set; }

        /// <summary>
        /// The <see cref="Entities.TimeOfDay"/> at which this spawn can take place.
        /// </summary>
        [ForeignKey("TimeOfDayId")]
        public TimeOfDay TimeOfDay { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.TimeOfDay"/>.
        /// </summary>
        public int TimeOfDayId { get; set; }
    }
}
