using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace PokeOneWeb.Data.Entities
{
    public class ElementalTypeDamageRelation
    {
        public int Id { get; set; }
        public double AttackEffectivity { get; set; }

        [ForeignKey("AttackingTypeId")]
        public ElementalType AttackingType { get; set; }
        public int AttackingTypeId { get; set; }

        [ForeignKey("DefendingTypeId")]
        public ElementalType DefendingType { get; set; }
        public int DefendingTypeId { get; set; }
    }
}
