using System;

namespace PokeOneWeb.Data.Entities
{
    public class TimeOfDay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }
}
