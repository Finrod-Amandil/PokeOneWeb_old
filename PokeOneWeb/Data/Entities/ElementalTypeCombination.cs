using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// As a <see cref="PokemonSpeciesVariety"/> can have two types, each PokemonSpeciesVariety has
    /// an ElementalTypeCombination which contains these types. PokémonSpeciesVarieties with only one type
    /// still resolve that using an ElementalTypeCombination, with the second type being set to NULL.
    /// The two types are labelled "primary" and "secondary" type by convention, but there is no difference
    /// between the two except the order of mentioning them. Single-type Pokémon only have a primary type.
    /// </summary>
    public class ElementalTypeCombination
    {
        public int Id { get; set; }

        /// <summary>
        /// The first <see cref="ElementalType"/>.
        /// </summary>
        [ForeignKey("PrimaryTypeId")]
        public ElementalType PrimaryType { get; set; }

        /// <summary>
        /// Foreign key for the primary type.
        /// </summary>
        public int PrimaryTypeId { get; set; }

        /// <summary>
        /// The second <see cref="ElementalType"/>.
        /// </summary>
        [ForeignKey("SecondaryTypeId")]
        public ElementalType SecondaryType { get; set; }

        /// <summary>
        /// Foreign key for the secondary type.
        /// </summary>
        public int? SecondaryTypeId { get; set; }

        /// <summary>
        /// Which PokemonSpeciesVarieties have this type combination.
        /// </summary>
        public ICollection<PokemonSpecies> PokemonSpecies { get; set; }
    }
}
