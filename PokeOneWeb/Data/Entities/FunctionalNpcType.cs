using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Classifies Functional NPCs by type, i.e. Move Tutors, Move reminders etc.
    /// </summary>
    public class FunctionalNpcType
    {
        public int Id { get; set; }

        /// <summary>
        /// The display name for this type.
        /// </summary>
        public string FunctionName { get; set; }

        /// <summary>
        /// Which Npcs are of this type.
        /// </summary>
        public ICollection<FunctionalNpc> FunctionalNpcs { get; set; }
    }
}
