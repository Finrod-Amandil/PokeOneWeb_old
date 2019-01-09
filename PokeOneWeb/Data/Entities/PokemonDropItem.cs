using System.ComponentModel.DataAnnotations.Schema;
namespace PokeOneWeb.Data.Entities

{
    public class PokemonDropItem
    {
        public int Id { get; set; }
        public bool IsGuaranteed { get; set; }

        [ForeignKey("PokemonId")]
        public Pokemon Pokemon { get; set; }
        public int PokemonId { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        public int ItemId { get; set; }

    }
}