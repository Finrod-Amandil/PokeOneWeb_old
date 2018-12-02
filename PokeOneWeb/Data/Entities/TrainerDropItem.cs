using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class TrainerDropItem
    {
        public int Id { get; set; }

        [ForeignKey("TrainerId")]
        public Trainer Trainer { get; set; }
        public int TrainerId { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        public int ItemId { get; set; }
    }
}
