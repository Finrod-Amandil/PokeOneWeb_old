using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Struct-like class to represent a set of Pokemon stat values. Can be used to represent
    /// any stat set (base stats, EV yields...)
    /// </summary>
    [Table("Stats")]
    public class Stats
    {
        [Key]
        public int Id { get; set; }

        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public int Hp { get; set; }
    }
}
