using System.ComponentModel.DataAnnotations.Schema;
namespace PokeOneWeb.Data.Entities

{
    /// <summary>
    /// Transformation entity between <see cref="Entities.Pokemon"/> and <see cref="Entities.Item"/>.
    /// Models, which Items are dropped by Pokémon resp. obtained upon defeating a Pokémon.
    /// </summary>
    public class PokemonDropItem
    {
        public int Id { get; set; }

        /// <summary>
        /// Whether the <see cref="Entities.Pokemon"/> always drops the <see cref="Entities.Item"/>.
        /// </summary>
        public bool IsGuaranteed { get; set; }

        /// <summary>
        /// Which <see cref="Entities.Pokemon"/> drops the <see cref="Entities.Item"/>.
        /// </summary>
        [ForeignKey("PokemonId")]
        public Pokemon Pokemon { get; set; }

        /// <summary>
        /// Foreign key for the Pokemon.
        /// </summary>
        public int PokemonId { get; set; }

        /// <summary>
        /// Which <see cref="Entities.Item"/> is being dropped.
        /// </summary>
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        
        /// <summary>
        /// Foreign key for the Item.
        /// </summary>
        public int ItemId { get; set; }

    }
}