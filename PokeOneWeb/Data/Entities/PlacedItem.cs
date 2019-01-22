using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// An <see cref="Entities.Item"/> which is laying around in a <see cref="Location"/> and can be picked up.
    /// </summary>
    public class PlacedItem : LocationInteraction
    {
        /// <summary>
        /// The <see cref="Item"/>.
        /// </summary>
        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        /// <summary>
        /// Foreign key for the Item.
        /// </summary>
        [Column("PlacedItem_ItemId")]
        public int? ItemId { get; set; }

        /// <summary>
        /// Whether the Item is hidden (does not have the sprite visible PlacedItems have)
        /// </summary>
        [Column("PlacedItem_IsHidden")]
        public bool IsHidden { get; set; }
    }
}
