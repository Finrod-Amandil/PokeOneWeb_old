using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PlacedItem> PlacedItems { get; set; }
        public List<FruitTree> FruitTrees { get; set; }
        public List<ItemGift> ItemGifts { get; set; }
        public List<BossPokemonDropItem> DroppedByBossPokemon { get; set; }
        public List<BossTrainerDropItem> DroppedByBossTrainers { get; set; }
        public List<PokemonSpeciesDropItem> DroppedByPokemonSpecies { get; set; }
    }
}
