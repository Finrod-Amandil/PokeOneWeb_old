using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class Pokemon
    {
        public int Id { get; set; }
        public int Level { get; set; }

        [ForeignKey("PokemonSpeciesId")]
        public PokemonSpecies PokemonSpecies { get; set; }
        public int PokemonSpeciesId { get; set; }

        public List<PokemonMove> Moves { get; set; }
    }
}
