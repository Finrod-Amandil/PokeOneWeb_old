using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class FruitTree : LocationInteraction
    {
        [ForeignKey("FruitId")]
        public Item Fruit { get; set; }
        [Column("FruitTree_FruitId")]
        public int FruitId { get; set; }
    }
}
