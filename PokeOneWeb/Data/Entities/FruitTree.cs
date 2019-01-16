using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class FruitTree : LocationInteraction
    {
        [ForeignKey("FruitItemId")]
        public Item FruitItem { get; set; }
        [Column("FruitTree_FruitItemId")]
        public int FruitItemId { get; set; }

        [ForeignKey("FruitTreeTypeId")]
        public FruitTreeType FruitTreeType { get; set; }
        public int FruitTreeTypeId { get; set; }
    }
}
