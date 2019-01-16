using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class PokemonSpecies
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("ElementalTypeCombinationId")]
        public ElementalTypeCombination ElementalTypeCombination { get; set; }
        public int ElementalTypeCombinationId { get; set; }


        public List<PokemonGift> PokemonGifts { get; set; }
        public List<PokemonSpawn> PokemonSpawns { get; set; }
        public List<PokemonTrade> PokemonTrades { get; set; }
        public List<PokemonNpc> PokemonNpcs { get; set; }
        public List<Pokemon> Pokemon { get; set; }
    }
}
