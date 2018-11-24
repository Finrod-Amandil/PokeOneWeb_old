using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class PokemonMove
    {
        public int Id { get; set; }

        [ForeignKey("PokemonId")]
        public Pokemon Pokemon { get; set; }
        public int PokemonId { get; set; }

        [ForeignKey("MoveId")]
        public Move Move { get; set; }
        public int MoveId { get; set; }
    }
}
