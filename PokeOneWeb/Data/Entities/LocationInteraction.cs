using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PokeOneWeb.Data.Entities
{
    public abstract class LocationInteraction
    {
        public int Id { get; set; }
        public string PlacementDescription { get; set; }

        [ForeignKey("LocationId")]
        public Location Location { get; set; }
        public int LocationId { get; set; }

        [ForeignKey("CoordinatesId")]
        public Coordinates Coordinates { get; set; }
        public int CoordinatesId { get; set; }
    }
}
