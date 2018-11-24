using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class PokemonNpc : Npc
    {
        [ForeignKey("PokemonNpcSpeciesId")]
        public PokemonSpecies PokemonSpecies { get; set; }
        [Column("PokemonNpc_PokemonSpeciesId")]
        public int PokemonNpcSpeciesId { get; set; }
    }
}
