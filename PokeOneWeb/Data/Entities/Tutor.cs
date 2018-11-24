using System.ComponentModel.DataAnnotations.Schema;
using PokeOneWeb.Data.Entities.Enums;

namespace PokeOneWeb.Data.Entities
{
    public class Tutor : HumanNpc
    {
        [Column("Tutor_TutorType")]
        public TutorType TutorType { get; set; }
        
        [ForeignKey("TutorTaughtMoveId")]
        public Move TaughtMove { get; set; }
        [Column("Tutor_TaughtMoveId")]
        public int TutorTaughtMoveId { get; set; }
    }
}
