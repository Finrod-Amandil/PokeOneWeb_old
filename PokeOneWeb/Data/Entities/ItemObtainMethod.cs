using System;
using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Classifies <see cref="GloballyObtainableItem"/>s by obtain methods. Obtain methods
    /// include things like buying in a store, or obtaining items through headbutting.
    /// </summary>
    public class ItemObtainMethod
    {
        public int Id { get; set; }

        /// <summary>
        /// The display name for this method.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description for this method (how it works).
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Which items can be obtained through this method.
        /// </summary>
        public ICollection<GloballyObtainableItem> GloballyObtainableItems { get; set; }
    }
}
