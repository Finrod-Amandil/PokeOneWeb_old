using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class BossPokemon : PokemonNpc
    {
        [ForeignKey("BossPokemonPokemonId")]
        public Pokemon Pokemon { get; set; }
        [Column("BossPokemon_PokemonId")]
        public int BossPokemonPokemonId { get; set; }

        public List<BossPokemonDropItem> Drops { get; set; }

        [Column("BossPokemon_StartLevel")]
        public int StartLevel { get; set; }
    }
}
