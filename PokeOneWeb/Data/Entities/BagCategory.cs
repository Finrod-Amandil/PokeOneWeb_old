using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// In the in-game item bag, <see cref="Item"/>s are organized into bag categories.
    /// </summary>
    [Table("BagCategory")]
    public class BagCategory
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Display name for the category.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Which <see cref="Item"/>s appear in this BagCategory
        /// </summary>
        public ICollection<Item> Items { get; set; }
    }
}