using System;
using System.ComponentModel.DataAnnotations.Schema;
using PokeOneWeb.Data.Entities.Enums;
namespace PokeOneWeb.Data.Entities

{
    /// <summary>
    /// A Learnable Move describes that a specific <see cref="Entities.Move"/> can be learned by a
    /// <see cref="Entities.PokemonSpeciesVariety"/> through a specific method.
    /// </summary>
    public class LearnableMove
    {
        public int Id { get; set; }

        /// <summary>
        /// By which method the move can be learned.
        /// </summary>
        public MoveLearnMethod LearnMethod { get; set; }

        /// <summary>
        /// Whether the move can be obtained in PokéOne. Some moves may be missing
        /// the required conditions to actually learn the move, i.e. a move tutor not
        /// being available in PokéOne.
        /// </summary>
        public bool IsAvailable { get; set; }

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
