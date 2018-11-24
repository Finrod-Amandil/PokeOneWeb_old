using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class TrainerPokemon
    {
        public int Id { get; set; }

        [ForeignKey("TrainerId")]
        public Trainer Trainer { get; set; }
        public int TrainerId { get; set; }

        [ForeignKey("PokemonId")]
        public Pokemon Pokemon { get; set; }
        public int PokemonId { get; set; }
    }
}
