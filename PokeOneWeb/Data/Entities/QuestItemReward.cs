using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Transformation entity between <see cref="Entities.Item"/> and <see cref="Entities.Quest"/>.
    /// </summary>
    public class QuestItemReward
    {
        public int Id { get; set; }

        /// <summary>
        /// The Item which is gained upon completing the Quest.
        /// </summary>
        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        /// <summary>
        /// Foreign key for the Item.
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// The quest which yields this Item as reward.
        /// </summary>
        [ForeignKey("QuestId")]
        public Quest Quest { get; set; }

        /// <summary>
        /// Foreign key for the Quest.
        /// </summary>
        public int QuestId { get; set; }
    }
}
