using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// The Event entity models temporary ingame events such as Christmas Events.
    /// Each Event may be linked to an event-specific region which encompasses all locations
    /// which are solely accessible during the event.
    /// </summary>
    public class Event
    {
        public int Id { get; set; }

        /// <summary>
        /// Display name for the event
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The day the event started. May be null if unknown.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The day the event ended. May be null if unknown.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The event-specific <see cref="Entities.Region"/> which contains all event-exclusive <see cref="Location"/>s.
        /// </summary>
        [ForeignKey("RegionId")]
        public Region Region { get; set; }

        /// <summary>
        /// Foreign key for the Event <see cref="Entities.Region"/>.
        /// </summary>
        public int RegionId { get; set; }

    }
}
