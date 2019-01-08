using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    public class MoveTutor : FunctionalNpc
    {
        public ICollection<MoveTutorMove> MoveTutorMoves { get; set; }
    }
}
