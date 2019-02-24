using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PokeOneWeb.Data.Entities.Enums;
namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// A move that can be learned by <see cref="PokemonSpeciesVariety"/> and that can be used
    /// by a <see cref="Pokemon"/> during battle.
    /// </summary>
    [Table("Move")]
    public class Move
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The display name for this move.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The attack strength, if the move is an attacking move, Null otherwise.
        /// </summary>
        public int? Strength { get; set; }

        /// <summary>
        /// The probability with which this move is executed successfully as decimal
        /// value. Ranges from 0 to 1, with one being 100% accuracy.
        /// </summary>
        public double Accuracy { get; set; } = 1D;

        /// <summary>
        /// How often the move can be used during battle (PP = Power Points)
        /// </summary>
        public int PP { get; set; }

        /// <summary>
        /// What kind of move it is (physical / attacking...)
        /// </summary>
        public MoveDamageClass MoveDamageClass { get; set;}

        /// <summary>
        /// The <see cref="Entities.ElementalType"/> of the move.
        /// </summary>
        [ForeignKey("ElementalTypeId")]
        public ElementalType ElementalType { get; set; }

        /// <summary>
        /// Foreign key for the Elemental Type.
        /// </summary>
        public int ElementalTypeId { get; set; }
    }
}
