using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    /// <inheritdoc />
    /// <summary>
    /// Move Tutors are NPCs which can teach one or multiple moves to Pokémon.
    /// Tutors whose moves depend upon the <see cref="T:PokeOneWeb.Data.Entities.PokemonSpeciesVariety" /> presented
    /// are not modeled with MoveTutors, but as <see cref="T:PokeOneWeb.Data.Entities.FunctionalNpc" />s instead.
    /// </summary>
    public class MoveTutor : FunctionalNpc
    {
        /// <summary>
        /// Which moves the Tutor can teach.
        /// </summary>
        public ICollection<MoveTutorMove> MoveTutorMoves { get; set; }
    }
}
