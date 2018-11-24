using System.ComponentModel.DataAnnotations.Schema;
using PokeOneWeb.Data.Entities.Enums;

namespace PokeOneWeb.Data.Entities
{
    public class PokemonTrade
    {
        public int Id { get; set; }
        public PokemonTradeType PokemonTradeType { get; set; }
        public int PriceInCoins { get; set; }
        
        [ForeignKey("HumanNpcId")]
        public HumanNpc HumanNpc { get; set; }
        public int HumanNpcId { get; set; }

        [ForeignKey("PokemonSpeciesId")]
        public PokemonSpecies PokemonSpecies { get; set; }
        public int PokemonSpeciesId { get; set; }

        [ForeignKey("TradeForSpeciesId")]
        public PokemonSpecies TradeForSpecies { get; set; }
        public int TradeForSpeciesId { get; set; }
    }
}
