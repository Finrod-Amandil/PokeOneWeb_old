using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class ItemGift
    {
        public int Id { get; set; }

        [ForeignKey("HumanNpcId")]
        public HumanNpc HumanNpc { get; set; }
        public int HumanNpcId { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        public int ItemId { get; set; }

        public int Count { get; set; }
    }
}
