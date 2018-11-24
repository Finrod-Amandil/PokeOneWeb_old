using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class BossTrainer : Trainer
    {
        public List<BossTrainerDropItem> Drops { get; set; }

        [Column("BossTrainer_StartLevel")]
        public int StartLevel { get; set; }
    }
}
