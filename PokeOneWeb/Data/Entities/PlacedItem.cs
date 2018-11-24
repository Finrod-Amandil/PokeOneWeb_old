using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class PlacedItem : LocationInteraction
    {
        [ForeignKey("PlacedItemId")]
        public Item Item { get; set; }
        [Column("PlacedItem_ItemId")]
        public int? PlacedItemId { get; set; }

        [Column("PlacedItem_IsHidden")]
        public bool IsHidden { get; set; }
    }
}
