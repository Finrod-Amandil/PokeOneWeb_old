using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Classifies Functional NPCs by type, i.e. Move Tutors, Move reminders etc.
    /// </summary>
    [Table("FunctionalNpcType")]
    public class FunctionalNpcType
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The display name for this type.
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>
        /// Which NPCs are of this type.
        /// </summary>
        public ICollection<FunctionalNpc> FunctionalNpcs { get; set; }
    }
}
