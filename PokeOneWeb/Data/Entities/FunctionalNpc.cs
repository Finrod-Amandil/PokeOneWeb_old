using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Functional NPCs are <see cref="HumanNpc"/>s which have additional functionality
    /// beside dialogues, and are not Trainers.
    /// </summary>
    public class FunctionalNpc : HumanNpc
    {
        /// <summary>
        /// Of which type this FunctionalNPC is.
        /// </summary>
        [ForeignKey("TypeId")]
        public FunctionalNpcType Type { get; set; }

        /// <summary>
        /// Foreign key for Type
        /// </summary>
        [Column("FunctionalNpc_TypeId")]
        public int TypeId { get; set; }
    }
}
