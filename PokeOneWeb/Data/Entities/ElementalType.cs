using System.Collections.Generic;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Elemental Types affect the effectivity of attacking moves in battle.
    /// </summary>
    public class ElementalType
    {
        public int Id { get; set; }

        /// <summary>
        /// The display name for this type.
        /// </summary>
        public string Name { get; set; }

        //TODO: Determine how to store color.
        /// <summary>
        /// The display color for the type.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// All combinations this type appears in. Use ElementalTypeCombinations.PokemonSpeciesVarieties
        /// to obtain a list of all Pokémon with this type.
        /// </summary>
        public ICollection<ElementalTypeCombination> ElementalTypeCombinations { get; set; }

        /// <summary>
        /// Which <see cref="Move"/>s have this type.
        /// </summary>
        public ICollection<Move> Moves { get; set; }

        /// <summary>
        /// How effective this type is when attacking any other type or itself.
        /// </summary>
        public ICollection<ElementalTypeDamageRelation> AttackDamageRelations { get; set; }

        /// <summary>
        /// How effective this type is when defending, i.e. how much damage it takes as
        /// defending type when attacked by any other type or itself.
        /// </summary>
        public ICollection<ElementalTypeDamageRelation> DefenseDamageRelations { get; set; }
    }
}
