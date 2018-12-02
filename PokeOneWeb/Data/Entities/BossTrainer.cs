using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class BossTrainer : Trainer
    {
        [Column("BossTrainer_StartLevel")]
        public int StartLevel { get; set; }
    }
}
