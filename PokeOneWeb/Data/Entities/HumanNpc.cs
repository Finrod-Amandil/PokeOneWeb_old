using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <inheritdoc />
    /// <summary>
    /// Human NPCs differ from Pokemon NPCs through having a NPC-specific name.
    /// </summary>
    public class HumanNpc : Npc
    {
        /// <summary>
        /// The full name of the NPC, including trainer class (i.e. "Bugcatcher Charlie")
        /// </summary>
        [Column("HumanNpc_Name")]
        public string Name { get; set; }

        /// <summary>
        /// Which <see cref="PokemonTrade"/>s this NPC offers.
        /// </summary>
        public ICollection<PokemonTrade> PokemonTrades { get; set; }
    }
}
