using System.ComponentModel.DataAnnotations;
using PokeOneWeb.Data.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;
namespace PokeOneWeb.Data.Entities

{
    /// <summary>
    /// A learnable Move describes that a specific <see cref="Entities.Move"/> can be learned by a
    /// <see cref="Entities.PokemonSpeciesVariety"/> through a specific method.
    /// </summary>
    [Table("LearnableMove")]
    public class LearnableMove
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// By which method the move can be learned.
        /// </summary>
        public MoveLearnMethod LearnMethod { get; set; }

        /// <summary>
        /// Whether the move can be obtained in PokéOne. Some moves may be missing
        /// the required conditions to actually learn the move, i.e. a move tutor not
        /// being available in PokéOne. Defaults to true.
        /// </summary>
        public bool IsAvailable { get; set; } = true;

        /// <summary>
        /// The learnable move.
        /// </summary>
        [ForeignKey("MoveId")]
        public Move Move { get; set; }

        /// <summary>
        /// Foreign key for the move
        /// </summary>
        public int MoveId { get; set; }

        /// <summary>
        /// The PokemonSpeciesVariety that can learn the move.
        /// </summary>
        [ForeignKey("PokemonSpeciesVarietyId")]
        public PokemonSpeciesVariety PokemonSpeciesVariety { get; set; }

        /// <summary>
        /// Foreign key for the PokemonSpeciesVariety.
        /// </summary>
        public int PokemonSpeciesVarietyId { get; set; }



    }
}
