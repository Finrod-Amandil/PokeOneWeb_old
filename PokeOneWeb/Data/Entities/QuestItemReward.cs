using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class QuestItemReward
    {
        public int Id { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        public int ItemId { get; set; }

        [ForeignKey("QuestId")]
        public Quest Quest { get; set; }
        public int QuestId { get; set; }
    }
}
