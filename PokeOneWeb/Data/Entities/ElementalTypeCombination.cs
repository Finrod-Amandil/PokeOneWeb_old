using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class ElementalTypeCombination
    {
        public int Id { get; set; }

        [ForeignKey("PrimaryTypeId")]
        public ElementalType PrimaryType { get; set; }
        public int PrimaryTypeId { get; set; }

        [ForeignKey("SecondaryTypeId")]
        public ElementalType SecondaryType { get; set; }
        public int SecondaryTypeId { get; set; }

        public List<PokemonSpecies> PokemonSpecies { get; set; }
    }
}
