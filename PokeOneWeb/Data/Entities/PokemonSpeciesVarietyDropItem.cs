using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Transformation entity between <see cref="Entities.PokemonSpeciesVariety"/> and
    /// <see cref="Entities.Item"/>. An item which may be dropped by any specimen of
    /// a specific PokemonSpeciesVariety.
    /// </summary>
    [Table("PokemonSpeciesVarietyDropItem")]
    public class PokemonSpeciesVarietyDropItem
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The <see cref="Entities.PokemonSpeciesVariety"/> dropping the item upon defeating it.
        /// </summary>
        [ForeignKey("PokemonSpeciesVarietyId")]
        public PokemonSpeciesVariety PokemonSpeciesVariety { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.PokemonSpeciesVariety"/>
        /// </summary>
        public int PokemonSpeciesVarietyId { get; set; }

        /// <summary>
        /// The <see cref="Entities.Item"/> being dropped.
        /// </summary>
        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.Item"/>
        /// </summary>
        public int ItemId { get; set; }
    }
}