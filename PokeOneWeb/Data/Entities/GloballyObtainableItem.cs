using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Globally Obtainable Items are Items which can be obtained at multiple places in the game world
    /// such as items bought from stores (except Department Stores), from Headbutting or Rock Smashing.
    /// </summary>
    [Table("GloballyObtainableItem")]
    public class GloballyObtainableItem
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The <see cref="Entities.Item"/>.
        /// </summary>
        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.Item"/>.
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// The method with which this Item can be obtained.
        /// </summary>
        [ForeignKey("ItemObtainMethodId")]
        public ItemObtainMethod ItemObtainMethod { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.ItemObtainMethod"/>
        /// </summary>
        public int ItemObtainMethodId { get; set; }
    }
}
