using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class PokemonNpc : Npc
    {
        [ForeignKey("PokemonId")]
        public Pokemon Pokemon { get; set; }
        [Column("PokemonNpc_PokemonId")]
        public int PokemonId { get; set; }

        [ForeignKey("PokemonNpcTypeId")]
        public PokemonNpcType PokemonNpcType { get; set; }
        [Column("PokemonNpc_PokemonNpcTypeId")]
        public int PokemonNpcTypeId { get; set; }
    }
}
