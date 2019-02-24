using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Classifies <see cref="FruitTree"/>s.
    /// </summary>
    [Table("FruitTreeType")]
    public class FruitTreeType
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Display name for this type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Which <see cref="FruitTree"/>s are of this type.
        /// </summary>
        public ICollection<FruitTree> FruitTrees { get; set; }
    }
}
