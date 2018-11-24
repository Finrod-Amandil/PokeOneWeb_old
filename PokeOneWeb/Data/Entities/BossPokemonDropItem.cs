using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public class BossPokemonDropItem
    {
        public int Id { get; set; }

        [ForeignKey("BossPokemonId")]
        public BossPokemon BossPokemon { get; set; }
        public int BossPokemonId { get; set; }


        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        public int ItemId { get; set; }
    }
}
