namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Classifies <see cref="FruitTree"/>s.
    /// </summary>
    public class FruitTreeType
    {
        public int Id { get; set; }

        /// <summary>
        /// Display name for this type.
        /// </summary>
        public string Name { get; set; }
    }
}
