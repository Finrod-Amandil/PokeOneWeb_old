using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Location> Locations { get; set; }
    }
}
