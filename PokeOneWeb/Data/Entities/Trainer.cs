using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <inheritdoc />
    /// <summary>
    /// Trainers are NPCs which battle the player upon interacting with them.
    /// </summary>
    public class Trainer : HumanNpc
    {
        /// <summary>
        /// What type of Trainer this is.
        /// </summary>
        [ForeignKey("TrainerTypeId")]
        public TrainerType TrainerType { get; set; }

        /// <summary>
        /// Foreign key for the Trainer Type.
        /// </summary>
        [Column("Trainer_TrainerTypeId")]
        public int TrainerTypeId { get; set; }

        /// <summary>
        /// How much trainer XP defeating the Trainer yields.
        /// </summary>
        [Column("Trainer_ExperienceReward")]
        public int ExperienceReward { get; set; }

        /// <summary>
        /// How much money defeating the Trainer yields.
        /// </summary>
        [Column("Trainer_MoneyReward")]
        public int MoneyReward { get; set; }

        /// <summary>
        /// Which items the Trainer drops after defeat.
        /// </summary>
        public ICollection<TrainerDropItem> TrainerDropItems { get; set; }

        /// <summary>
        /// Which Pokémon the Trainer uses.
        /// </summary>
        public ICollection<TrainerPokemon> TrainerPokemon { get; set; }
    }
}
