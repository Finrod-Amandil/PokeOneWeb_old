using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Transformation table for an <see cref="Entities.Item"/> being given as a gift by a
    /// <see cref="Entities.Npc"/>
    /// </summary>
    [Table("ItemGift")]
    public class ItemGift
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The <see cref="Entities.Npc"/> giving the gift.
        /// </summary>
        [ForeignKey("NpcId")]
        public Npc Npc { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.Npc"/>.
        /// </summary>
        public int NpcId { get; set; }

        /// <summary>
        /// The gifted <see cref="Entities.Item"/>.
        /// </summary>
        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.Item"/>.
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// How many of the specified items are being gifted. Defaults to 1.
        /// </summary>
        public int Count { get; set; } = 1;
    }
}
