using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Elemental Types affect the effectivity of attacking moves in battle.
    /// </summary>
    [Table("ElementalType")]
    public class ElementalType
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The display name for this type.
        /// </summary>
        public string Name { get; set; }

        //TODO: Determine how to store color.
        /// <summary>
        /// The display color for the type.
        /// </summary>
        //public string Color { get; set; }

        /// <summary>
        /// Which <see cref="Move"/>s have this type.
        /// </summary>
        public ICollection<Move> Moves { get; set; }

        /// <summary>
        /// How effective this type is when attacking any other type or itself.
        /// </summary>
        [InverseProperty("AttackingType")]
        public ICollection<ElementalTypeDamageRelation> AttackDamageRelations { get; set; }

        /// <summary>
        /// How effective this type is when defending, i.e. how much damage it takes as
        /// defending type when attacked by any other type or itself.
        /// </summary>
        [InverseProperty("DefendingType")]
        public ICollection<ElementalTypeDamageRelation> DefenseDamageRelations { get; set; }
    }
}
