using System.ComponentModel.DataAnnotations.Schema;
using PokeOneWeb.Data.Entities.Enums;
namespace PokeOneWeb.Data.Entities
{
    public class Move
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public double Accuracy { get; set; }
        public int PP { get; set; }

        public MoveDamageClass MoveDamageClass { get; set;}

        [ForeignKey("ElementalTypeId")]
        public ElementalType ElementalType { get; set; }
        public int ElementalTypeId { get; set; }

    }
}
