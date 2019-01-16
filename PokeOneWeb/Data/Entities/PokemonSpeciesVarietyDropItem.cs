using System.ComponentModel.DataAnnotations.Schema;
namespace PokeOneWeb.Data.Entities
{
    public class PokemonSpeciesVarietyDropItem
    {
        public int Id { get; set; }

        [ForeignKey("PokemonSpeciesVarietyId")]
        public PokemonSpeciesVariety PokemonSpeciesVariety { get; set; }
        public int PokemonSpeciesVarietyId { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        public int ItemId { get; set; }
    }
}