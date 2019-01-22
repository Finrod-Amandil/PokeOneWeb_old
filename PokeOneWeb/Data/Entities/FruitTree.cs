using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Fruit Trees are <see cref="LocationInteraction"/>s which yield one or multiple fruits
    /// when being interacted with.
    /// </summary>
    public class FruitTree : LocationInteraction
    {
        /// <summary>
        /// The fruit this tree drops, as <see cref="Item"/>
        /// </summary>
        [ForeignKey("FruitItemId")]
        public Item FruitItem { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="FruitItem"/>
        /// </summary>
        [Column("FruitTree_FruitItemId")]
        public int FruitItemId { get; set; }

        /// <summary>
        /// The type of Fruit Tree, expressing which type of Fruit is being
        /// dropped.
        /// </summary>
        [ForeignKey("FruitTreeTypeId")]
        public FruitTreeType FruitTreeType { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="FruitTreeType"/>
        /// </summary>
        [Column("FruitTree_FruitTreeTypeId")]
        public int FruitTreeTypeId { get; set; }
    }
}
