using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Classifies <see cref="Trainer"/>s.
    /// </summary>
    public class TrainerType
    {
        public int Id { get; set; }

        /// <summary>
        /// The display name for this Type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Which Trainers are of this type.
        /// </summary>
        public ICollection<Trainer> Trainers { get; set; }
    }
}