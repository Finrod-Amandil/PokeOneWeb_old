using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Transformation entity between <see cref="Entities.Item"/> and <see cref="Entities.Trainer"/>.
    /// Models, which Items are being dropped by Trainers, resp. obtained upon defeating a Trainer.
    /// </summary>
    [Table("TrainerDropItem")]
    public class TrainerDropItem
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Whether the <see cref="Entities.Trainer"/> always drops the <see cref="Entities.Item"/>.
        /// </summary>
        public bool IsGuaranteed { get; set; }

        /// <summary>
        /// The <see cref="Entities.Trainer"/> dropping the <see cref="Entities.Item"/>.
        /// </summary>
        [ForeignKey("TrainerId")]
        public Trainer Trainer { get; set; }

        /// <summary>
        /// Foreign key for the Trainer.
        /// </summary>
        public int TrainerId { get; set; }

        /// <summary>
        /// Which <see cref="Entities.Item"/> is being dropped.
        /// </summary>
        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        /// <summary>
        /// Foreign key for the Item.
        /// </summary>
        public int ItemId { get; set; }
    }
}
