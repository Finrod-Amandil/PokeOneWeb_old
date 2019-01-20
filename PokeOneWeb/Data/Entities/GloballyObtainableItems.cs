using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    public class GloballyObtainableItems
    {
        public int Id { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        public int ItemId { get; set; }

        [ForeignKey("ItemObtainMethodId")]
        public ItemObtainMethod ItemObtainMethod { get; set; }
        public int ItemObtainMethodId { get; set; }
    }
}
