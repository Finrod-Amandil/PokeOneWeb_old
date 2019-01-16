using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public abstract class LocationInteraction
    {
        public int Id { get; set; }
        public string PlacementDescription { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Notes { get; set; }

        [ForeignKey("LocationId")]
        public Location Location { get; set; }
        public int LocationId { get; set; }
    }
}
