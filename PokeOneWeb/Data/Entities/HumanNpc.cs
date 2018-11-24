using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class HumanNpc : Npc
    {
        [Column("HumanNpc_Name")]
        public string Name { get; set; }
    }
}
