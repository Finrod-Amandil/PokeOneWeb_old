using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PokeOneWeb.Data.Entities.Enums;

namespace PokeOneWeb.Data.Entities
{
    public class Quest
    {
        public int Id { get; set; }
        public QuestType QuestType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ExperienceReward { get; set; }
        public int MoneyReward { get; set; }

        [ForeignKey("NpcId")]
        public Npc Npc { get; set; }
        public int NpcId { get; set; }

        [ForeignKey("LocationId")]
        public Location Location { get; set; }
        public int LocationId { get; set; }
    }
}
