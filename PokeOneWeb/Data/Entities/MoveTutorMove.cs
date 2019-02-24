using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Transformation entity between <see cref="Entities.MoveTutor"/> and
    /// <see cref="Entities.Move"/>. A move which can be taught by a Tutor.
    /// </summary>
    [Table("MoveTutorMove")]
    public class MoveTutorMove
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The MoveTutor teaching the move.
        /// </summary>
        [ForeignKey("MoveTutorId")]
        public MoveTutor MoveTutor { get; set; }

        /// <summary>
        /// Foreign key for the Move Tutor.
        /// </summary>
        public int MoveTutorId { get; set; }

        /// <summary>
        /// Which Move the MoveTutor teaches.
        /// </summary>
        [ForeignKey("TaughtMoveId")]
        public Move TaughtMove { get; set; }

        /// <summary>
        /// Foreign key for the taught Move.
        /// </summary>
        public int TaughtMoveId { get; set; }
    }
}
