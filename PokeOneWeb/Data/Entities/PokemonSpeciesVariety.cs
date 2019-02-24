using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PokeOneWeb.Data.Entities.Enums;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Certain <see cref="Entities.PokemonSpecies"/> have multiple varieties which can differ in almost any
    /// property. This class is used to represent these varieties.
    /// </summary>
    [Table("PokemonSpeciesVariety")]
    public class PokemonSpeciesVariety
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// A name for this variety (may be identical to the name of the <see cref="PokemonSpecies"/>)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Whether this variety is the default variety. The default variety is the variety which will
        /// be used whenever the <see cref="PokemonSpecies"/> as a whole is considered.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Whether it is currently possible to obtain this variety.
        /// </summary>
        public PokemonAvailability Availability { get; set; }

        /// <summary>
        /// The <see cref="Entities.PokemonSpecies"/> this variety belongs to.
        /// </summary>
        [ForeignKey("PokemonSpeciesId")]
        public PokemonSpecies PokemonSpecies { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.PokemonSpecies"/>.
        /// </summary>
        public int PokemonSpeciesId { get; set; }

        /// <summary>
        /// Which of the <see cref="Forms"/> is the default one.
        /// </summary>
        [ForeignKey("DefaultFormId")]
        public PokemonSpeciesVarietyForm DefaultForm { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="DefaultForm"/> (<see cref="PokemonSpeciesVariety"/>).
        /// </summary>
        public int DefaultFormId { get; set; }

        /// <summary>
        /// The Base Stats of this Variety.
        /// </summary>
        [ForeignKey("BaseStatsId")]
        public Stats BaseStats { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="BaseStats"/> (<see cref="Stats"/>).
        /// </summary>
        public int BaseStatsId { get; set; }

        /// <summary>
        /// How many EV points this variety yields when being defeated.
        /// </summary>
        [ForeignKey("EvYieldId")]
        public Stats EvYield { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="EvYield"/> (<see cref="Stats"/>).
        /// </summary>
        public int EvYieldId { get; set; }

        /// <summary>
        /// Which elemental type(s) this variety has.
        /// </summary>
        [ForeignKey("ElementalTypeCombinationId")]
        public ElementalTypeCombination ElementalTypeCombination { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.ElementalTypeCombination"/>.
        /// </summary>
        public int ElementalTypeCombinationId { get; set; }

        /// <summary>
        /// The primary <see cref="Ability"/> / Ability slot 1 this variety has.
        /// </summary>
        [ForeignKey("PrimaryAbilityId")]
        public Ability PrimaryAbility { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="PrimaryAbility"/> (<see cref="Ability"/>).
        /// </summary>
        public int PrimaryAbilityId { get; set; }

        /// <summary>
        /// The secondary <see cref="Ability"/> / Ability slot 2 this variety has.
        /// </summary>
        [ForeignKey("SecondaryAbilityId")]
        public Ability SecondaryAbility { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="SecondaryAbility"/> (<see cref="Ability"/>).
        /// </summary>
        public int SecondaryAbilityId { get; set; }

        /// <summary>
        /// The hidden <see cref="Ability"/> this variety has.
        /// </summary>
        [ForeignKey("HiddenAbilityId")]
        public Ability HiddenAbility { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="HiddenAbility"/> (<see cref="Ability"/>).
        /// </summary>
        public int HiddenAbilityId { get; set; }

        /// <summary>
        /// The learnset of this variety / which moves it can learn.
        /// </summary>
        public ICollection<LearnableMove> LearnableMoves { get; set; }

        /// <summary>
        /// Which item(s) a specimen of this variety may drop if it is defeated.
        /// </summary>
        public ICollection<PokemonSpeciesVarietyDropItem> ItemDrops { get; set; }

        /// <summary>
        /// Which forms this variety has. Every variety has at least one form.
        /// </summary>
        [InverseProperty("PokemonSpeciesVariety")]
        public ICollection<PokemonSpeciesVarietyForm> Forms { get; set; }

        /// <summary>
        /// Through which <see cref="PokemonSpawn"/>s this variety may be obtained.
        /// </summary>
        public ICollection<PokemonSpawn> PokemonSpawns { get; set; }

        /// <summary>
        /// Through which <see cref="PokemonGift"/>s this variety may be obtained.
        /// </summary>
        public ICollection<PokemonGift> PokemonGifts { get; set; }

        /// <summary>
        /// Through which <see cref="PokemonTrade"/>s this variety may be obtained.
        /// </summary>
        public ICollection<PokemonTrade> PokemonTrades { get; set; }

        /// <summary>
        /// Which specific specimen are of this <see cref="PokemonSpeciesVariety"/>
        /// </summary>
        public ICollection<Pokemon> Pokemon { get; set; }
    }
}