using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class FunctionalNpc : HumanNpc
    {
        [ForeignKey("TypeId")]
        public FunctionalNpcType Type { get; set; }
        [Column("FunctionalNpc_TypeId")]
        public int TypeId { get; set; }
    }
}
