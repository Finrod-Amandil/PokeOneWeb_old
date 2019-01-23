using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// A Pokemon NPC which when battled does also yield Trainer XP and Money.
    /// Item rewards are modelled using the <see cref="Pokemon"/> entity referenced
    /// by the superclass.
    /// </summary>
    public class BossPokemon : PokemonNpc
    {
        /// <summary>
        /// How much trainer XP this Boss Pokemon yields after defeat.
        /// </summary>
        [Column("BossPokemon_ExperienceReward")]
        public int ExperienceReward { get; set; }

        /// <summary>
        /// How much money this Boss Pokemon yields after defeat.
        /// </summary>
        [Column("BossPokemon_MoneyReward")]
        public int MoneyReward { get; set; }
    }
}
