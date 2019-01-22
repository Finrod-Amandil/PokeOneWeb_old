using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("BagCategoryId")]
        public BagCategory BagCategory { get; set; }
        public int BagCategoryId { get; set; }

        public List<PlacedItem> PlacedItems { get; set; }
        public List<FruitTree> FruitTrees { get; set; }
        public List<ItemGift> ItemGifts { get; set; }
        public List<PokemonDropItem> DroppedByPokemon { get; set; }
        public List<TrainerDropItem> DroppedByBossTrainers { get; set; }
        public List<PokemonSpeciesVarietyDropItem> DroppedByPokemonSpeciesVarieties { get; set; }
        public List<GloballyObtainableItem> GloballyObtainableItems { get; set; }
    }
}
