using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// A <see cref="PokemonSpawn"/> represents the event of a wild <see cref="PokemonSpeciesVariety"/>
    /// appearing when interacting with a <see cref="Entities.PokemonSpawnPoint"/>.
    /// </summary>
    [Table("PokemonSpawn")]
    public class PokemonSpawn
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Whether this spawn is confirmed to be able to occur.
        /// </summary>
        public bool IsConfirmed { get; set; }

        /// <summary>
        /// Additional notes which contain information which is too specific
        /// to be handled by the other properties (i.e. spawn rarities varying
        /// throughout the day)
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Which rarity class (i.e. "Common" or "Rare") this spawn belongs to.
        /// </summary>
        [ForeignKey("SpawnRarityId")]
        public SpawnRarity SpawnRarity { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.SpawnRarity"/>.
        /// </summary>
        public int SpawnRarityId { get; set; }

        /// <summary>
        /// The <see cref="Entities.PokemonSpeciesVariety"/> this spawn reveals.
        /// </summary>
        [ForeignKey("PokemonSpeciesVarietyId")]
        public PokemonSpeciesVariety PokemonSpeciesVariety { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.PokemonSpeciesVariety"/>
        /// </summary>
        public int PokemonSpeciesVarietyId { get; set; }

        /// <summary>
        /// Where this spawn can occur.
        /// </summary>
        [ForeignKey("PokemonSpawnPointId")]
        public PokemonSpawnPoint PokemonSpawnPoint { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.PokemonSpawnPoint"/>
        /// </summary>
        public int PokemonSpawnPointId { get; set; }

        /// <summary>
        /// During which times of day this spawn can occur.
        /// </summary>
        public ICollection<PokemonSpawnTimeOfDay> TimesOfDay { get; set; }
    }
}
