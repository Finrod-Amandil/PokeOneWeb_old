using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// A <see cref="PokemonSpeciesVarietyForm"/> represents a visual manifestation of a <see cref="Entities.PokemonSpeciesVariety"/>.
    /// Each <see cref="Entities.PokemonSpeciesVariety"/> has at least one form, but may have multiple in some cases. Multiple <see cref="PokemonSpeciesVarietyForm"/>s
    /// of the same <see cref="Entities.PokemonSpeciesVariety"/> only differ in visuals.
    /// </summary>
    [Table("PokemonSpeciesVarietyForm")]
    public class PokemonSpeciesVarietyForm
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// A name for this form.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Whether this form is the default for of the <see cref="PokemonSpeciesVariety"/>
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// A small image of the form for lists. Serialized using Base64.
        /// </summary>
        public string Sprite { get; set; }

        /// <summary>
        /// A larger artwork of this form. Serialized using Base64.
        /// </summary>
        public string Artwork { get; set; }

        /// <summary>
        /// Artwork of the shiny variant of this form. Serialized using Base64
        /// </summary>
        public string ShinyArtwork { get; set; }

        /// <summary>
        /// To which <see cref="Entities.PokemonSpeciesVariety"/> this form belongs to.
        /// </summary>
        [ForeignKey("PokemonSpeciesVarietyId")]
        public PokemonSpeciesVariety PokemonSpeciesVariety { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.PokemonSpeciesVariety"/>
        /// </summary>
        public int PokemonSpeciesVarietyId { get; set; }
    }
}
