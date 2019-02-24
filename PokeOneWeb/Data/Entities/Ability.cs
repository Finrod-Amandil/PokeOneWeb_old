using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Abilities grant <see cref="Pokemon"/> various special effects during and/or outside of battles.
    /// Every Pokémon has exactly one ability, but a <see cref="PokemonSpeciesVariety"/> may have a pool
    /// of multiple abilities to choose from.
    /// </summary>
    [Table("Ability")]
    public class Ability
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The display name for the ability
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the effect of the ability
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Which PokémonSpeciesVarieties can obtain this ability as primary ability.
        /// </summary>
        [InverseProperty("PrimaryAbility")]
        public ICollection<PokemonSpeciesVariety> PokemonSpeciesVarietiesAsPrimaryAbility { get; set; }

        /// <summary>
        /// Which PokémonSpeciesVarieties can obtain this ability as secondary ability.
        /// </summary>
        [InverseProperty("SecondaryAbility")]
        public ICollection<PokemonSpeciesVariety> PokemonSpeciesVarietiesAsSecondaryAbility { get; set; }

        /// <summary>
        /// Which PokémonSpeciesVarieties can obtain this ability as hidden ability.
        /// </summary>
        [InverseProperty("HiddenAbility")]
        public ICollection<PokemonSpeciesVariety> PokemonSpeciesVarietiesAsHiddenAbility { get; set; }

        /// <summary>
        /// Which Pokemon specimen have this ability.
        /// </summary>
        public ICollection<Pokemon> Pokemon { get; set; }
    }
}
