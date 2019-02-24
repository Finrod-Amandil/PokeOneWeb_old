using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Classifies <see cref="PokemonNpc"/>s.
    /// </summary>
    [Table("PokemonNpcType")]
    public class PokemonNpcType
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The display name of this type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Which <see cref="PokemonNpc"/>s are of this type.
        /// </summary>
        public ICollection<PokemonNpc> PokemonNpcs { get; set; }
    }
}