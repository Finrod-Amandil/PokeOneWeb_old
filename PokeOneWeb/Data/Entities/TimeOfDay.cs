using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// <see cref="PokemonSpawn"/> may be dependent on what time it currently is in-game. This class represents an
    /// instance of one of the time periods along with the exact times it starts and ends at.
    /// </summary>
    [Table("TimeOfDay")]
    public class TimeOfDay
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// A name for this time period (i.e. "morning")
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The time this period starts at. The date part is irrelevant.
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// The time this period ends at. The date part is irrelevant.
        /// </summary>
        public DateTime Finish { get; set; }
    }
}
