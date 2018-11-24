using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class PokemonGift
    {
        public int Id { get; set; }

        [ForeignKey("HumanNpcId")]
        public HumanNpc HumanNpc { get; set; }
        public int HumanNpcId { get; set; }

        [ForeignKey("PokemonSpeciesId")]
        public PokemonSpecies PokemonSpecies { get; set; }
        public int PokemonSpeciesId { get; set; }
    }
}
