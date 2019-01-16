using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class BossPokemon : PokemonNpc
    {
        [Column("BossPokemon_ExperienceReward")]
        public int ExperienceReward { get; set; }

        [Column("BossPokemon_MoneyReward")]
        public int MoneyReward { get; set; }
    }
}
