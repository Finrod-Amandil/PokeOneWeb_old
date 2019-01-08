using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class PlacedItem : LocationInteraction
    {
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        [Column("PlacedItem_ItemId")]
        public int? ItemId { get; set; }

        [Column("PlacedItem_IsHidden")]
        public bool IsHidden { get; set; }
    }
}
