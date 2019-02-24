using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Classifies <see cref="Trainer"/>s.
    /// </summary>
    [Table("TrainerType")]
    public class TrainerType
    {
        [Key]
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