using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PokeOneWeb.Data.Entities.Enums;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Quests are tasks that the player can complete to make progress in the game's story and/or gain experience.
    /// </summary>
    public class Quest
    {
        public int Id { get; set; }

        /// <summary>
        /// What kind of type the quest is.
        /// </summary>
        public QuestType QuestType { get; set; }

        /// <summary>
        /// The display title for this Quest.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A description of the task the Quest consists of.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// From whom or where the Quest is obtained.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// How many Trainer XP points are gained upon completing this Quest.
        /// </summary>
        public int ExperienceReward { get; set; }

        /// <summary>
        /// How much money is gained upon completing this Quest.
        /// </summary>
        public int MoneyReward { get; set; }

        /// <summary>
        /// Most Quests are associated with a Location - usually the Location the task of the Quest needs to be executed at.
        /// </summary>
        [ForeignKey("LocationId")]
        public Location Location { get; set; }

        /// <summary>
        /// Foreign key for the Location. May be null.
        /// </summary>
        public int? LocationId { get; set; }

        /// <summary>
        /// Which items are gained upon completing this Quest.
        /// </summary>
        public ICollection<QuestItemReward> ItemRewards { get; set; }
    }
}
