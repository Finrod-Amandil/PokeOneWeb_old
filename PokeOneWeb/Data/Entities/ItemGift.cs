using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Transformation table for an <see cref="Entities.Item"/> being given as a gift by a
    /// <see cref="Entities.HumanNpc"/>
    /// </summary>
    public class ItemGift
    {
        public int Id { get; set; }

        /// <summary>
        /// The <see cref="Entities.HumanNpc"/> giving the gift.
        /// </summary>
        [ForeignKey("HumanNpcId")]
        public HumanNpc HumanNpc { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.HumanNpc"/>.
        /// </summary>
        public int HumanNpcId { get; set; }

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
