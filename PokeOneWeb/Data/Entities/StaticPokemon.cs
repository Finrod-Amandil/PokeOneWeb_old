using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class StaticPokemon : PokemonNpc
    {
        [ForeignKey("StaticPokemonPokemonId")]
        public Pokemon Pokemon { get; set; }
        [Column("StaticPokemon_PokemonId")]
        public int StaticPokemonPokemonId { get; set; }
    }
}
