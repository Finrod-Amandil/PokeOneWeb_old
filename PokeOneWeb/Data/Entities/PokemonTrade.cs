using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PokeOneWeb.Data.Entities.Enums;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// The <see cref="PokemonTrade"/> entity represents an occasion where the player
    /// may receive a Pokemon by trading it for some good. The good to trade my currently be
    /// one of in-game currency, game corner coins or a specimen of another specific
    /// <see cref="PokemonSpeciesVariety"/>.
    /// </summary>
    [Table("PokemonTrade")]
    public class PokemonTrade
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Enum to specify which kind of Trade this is, i.e. against which type of goods
        /// the <see cref="PokemonSpeciesVariety"/> needs to be traded.
        /// </summary>
        public PokemonTradeType PokemonTradeType { get; set; }

        /// <summary>
        /// How many Game Corner coins need to be traded.
        /// </summary>
        public int? PriceInCoins { get; set; }

        /// <summary>
        /// How many PokéDollars need to be traded.
        /// </summary>
        public int? PriceInPokeDollar { get; set; }
        
        /// <summary>
        /// Which NPC offers the trade.
        /// </summary>
        [ForeignKey("HumanNpcId")]
        public HumanNpc HumanNpc { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.HumanNpc"/>.
        /// </summary>
        public int HumanNpcId { get; set; }

        /// <summary>
        /// Which <see cref="Entities.PokemonSpeciesVariety"/> is obtained of the Trade is completed.
        /// </summary>
        [ForeignKey("PokemonSpeciesVarietyId")]
        public PokemonSpeciesVariety PokemonSpeciesVariety { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="Entities.PokemonSpeciesVariety"/>
        /// </summary>
        public int PokemonSpeciesVarietyId { get; set; }

        /// <summary>
        /// Which <see cref="Entities.PokemonSpeciesVariety"/> needs to be given by the player.
        /// </summary>
        [ForeignKey("TradeForSpeciesId")]
        public PokemonSpeciesVariety TradeForSpeciesVariety { get; set; }

        /// <summary>
        /// Foreign key for the <see cref="TradeForSpecies"/> (<see cref="Entities.PokemonSpeciesVariety"/>).
        /// </summary>
        public int TradeForSpeciesId { get; set; }
    }
}
