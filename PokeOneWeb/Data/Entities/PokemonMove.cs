using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Transformation entity between <see cref="Entities.Pokemon"/> and <see cref="Entities.Move"/>.
    /// </summary>
    [Table("PokemonMove")]
    public class PokemonMove
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The <see cref="Entities.Pokemon"/> knowing the Move.
        /// </summary>
        [ForeignKey("PokemonId")]
        public Pokemon Pokemon { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.Pokemon"/>
        /// </summary>
        public int PokemonId { get; set; }

        /// <summary>
        /// Which <see cref="Entities.Move"/> is known.
        /// </summary>
        [ForeignKey("MoveId")]
        public Move Move { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.Move"/>.
        /// </summary>
        public int MoveId { get; set; }
    }
}
