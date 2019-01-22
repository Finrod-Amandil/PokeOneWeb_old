using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// A <see cref="Entities.Pokemon"/> which is used by a <see cref="Entities.Trainer"/>.
    /// </summary>
    public class TrainerPokemon
    {
        public int Id { get; set; }

        /// <summary>
        /// The Trainer using the Pokemon.
        /// </summary>
        [ForeignKey("TrainerId")]
        public Trainer Trainer { get; set; }

        /// <summary>
        /// Foreign key for the Trainer.
        /// </summary>
        public int TrainerId { get; set; }

        /// <summary>
        /// The Pokemon used by the Trainer.
        /// </summary>
        [ForeignKey("PokemonId")]
        public Pokemon Pokemon { get; set; }

        /// <summary>
        /// Foreign key for the Pokemon.
        /// </summary>
        public int PokemonId { get; set; }
    }
}
