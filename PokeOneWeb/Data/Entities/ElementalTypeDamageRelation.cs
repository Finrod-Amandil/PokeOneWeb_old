using System.ComponentModel.DataAnnotations.Schema;
namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Describes how effective an attack of a specific <see cref="ElementalType"/> is against a specific defending <see cref="ElementalType"/>.
    /// In order to get the effectivity of a defending <see cref="ElementalTypeCombination"/> multiply the ElementalTypeDamageRelations
    /// of each type of the combination.
    /// </summary>
    public class ElementalTypeDamageRelation
    {
        public int Id { get; set; }

        /// <summary>
        /// The effectivity factor for this <see cref="ElementalType"/> constellation.
        /// </summary>
        public double AttackEffectivity { get; set; }

        /// <summary>
        /// The attacking <see cref="ElementalType"/>.
        /// </summary>
        [ForeignKey("AttackingTypeId")]
        public ElementalType AttackingType { get; set; }

        /// <summary>
        /// Foreign key for the Attacking Type.
        /// </summary>
        public int AttackingTypeId { get; set; }

        /// <summary>
        /// A single defending <see cref="ElementalType"/>.
        /// </summary>
        [ForeignKey("DefendingTypeId")]
        public ElementalType DefendingType { get; set; }

        /// <summary>
        /// Foreign key for the defending type.
        /// </summary>
        public int DefendingTypeId { get; set; }
    }
}
