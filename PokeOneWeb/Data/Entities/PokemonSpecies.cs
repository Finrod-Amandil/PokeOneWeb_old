using PokeOneWeb.Data.Entities.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// <see cref="PokemonSpecies"/> are used to specify which properties are equal to all specimen belonging to the same species. A <see cref="PokemonSpecies"/>
    /// may have one or multiple <see cref="PokemonSpeciesVariety"/>.
    /// </summary>
    [Table("PokemonSpecies")]
    public class PokemonSpecies
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// A unique number used for ordering within a Pokédex.
        /// </summary>
        public int PokedexNumber { get; set; }

        /// <summary>
        /// The name of the species.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Whether the species as a whole is available. This is to determine how many of
        /// the entries of the Pokédex can be filled.
        /// </summary>
        public PokemonAvailability Availability { get; set; }

        /// <summary>
        /// Which variety is considered the default one. This variety represents the
        /// species, if the species is listed as a whole such as in the Pokédex.
        /// </summary>
        [ForeignKey("DefaultVarietyId")]
        public PokemonSpeciesVariety DefaultVariety { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="DefaultVariety"/> (<see cref="PokemonSpeciesVariety"/>).
        /// </summary>
        public int DefaultVarietyId { get; set; }

        /// <summary>
        /// Which varieties this species has. Every species has at least one variety.
        /// </summary>
        [InverseProperty("PokemonSpecies")]
        public ICollection<PokemonSpeciesVariety> Varieties { get; set; }
    }
}
