using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class Trainer : HumanNpc
    {
        [Column("Trainer_TrainerType")]
        public TrainerType TrainerType { get; set; }
        [Column("Trainer_ExperienceReward")]
        public int ExperienceReward { get; set; }
        [Column("Trainer_MoneyReward")]
        public int MoneyReward { get; set; }
        public List<TrainerDropItem> TrainerDropItems { get; set; }

        public List<TrainerPokemon> TrainerPokemon { get; set; }
    }
}
