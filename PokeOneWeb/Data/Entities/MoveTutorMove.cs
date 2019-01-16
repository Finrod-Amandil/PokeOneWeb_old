using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class MoveTutorMove
    {
        public int Id { get; set; }

        [ForeignKey("MoveTutorId")]
        public MoveTutor MoveTutor { get; set; }
        public int MoveTutorId { get; set; }

        [ForeignKey("TaughtMoveId")]
        public Move TaughtMove { get; set; }
        public int TaughtMoveId { get; set; }
    }
}
