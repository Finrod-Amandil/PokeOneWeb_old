using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <inheritdoc />
    /// <summary>
    /// Functional NPCs are <see cref="T:PokeOneWeb.Data.Entities.HumanNpc" />s which have additional functionality
    /// beside dialogues, and are not Trainers.
    /// </summary>
    public class FunctionalNpc : HumanNpc
    {
        /// <summary>
        /// Of which type this FunctionalNPC is.
        /// </summary>
        [ForeignKey("FunctionalNpcTypeId")]
        public FunctionalNpcType FunctionalNpcType { get; set; }

        /// <summary>
        /// Foreign key for Type
        /// </summary>
        [Column("FunctionalNpc_FunctionalNpcTypeId")]
        public int FunctionalNpcTypeId { get; set; }
    }
}
