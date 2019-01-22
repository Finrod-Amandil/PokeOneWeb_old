namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// In the ingame item bag, <see cref="Item"/>s are organized into bag categories.
    /// </summary>
    public class BagCategory
    {
        public int Id { get; set; }

        /// <summary>
        /// Display name for the category.
        /// </summary>
        public string Name { get; set; }
    }
}