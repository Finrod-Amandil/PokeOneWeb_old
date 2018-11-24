using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class BossTrainerDropItem
    {
        public int Id { get; set; }

        [ForeignKey("BossTrainerId")]
        public BossTrainer BossTrainer { get; set; }
        public int BossTrainerId { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        public int ItemId { get; set; }
    }
}
