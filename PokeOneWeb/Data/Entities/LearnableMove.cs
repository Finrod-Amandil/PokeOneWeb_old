using System;
using System.ComponentModel.DataAnnotations.Schema;
using PokeOneWeb.Data.Entities.Enums;
namespace PokeOneWeb.Data.Entities

{
    public class LearnableMove
    {
        public int Id { get; set; }
        public MoveLearnMethod LearnMethod { get; set; }
        public bool IsAvailable { get; set; }

        [ForeignKey("MoveId")]
        public Move Move { get; set; }
        public int MoveId { get; set; }

        [ForeignKey("PokemonSpeciesVarietyId")]
        public PokemonSpeciesVariety PokemonSpeciesVariety { get; set; }
        public int PokemonSpeciesVarietyId { get; set; }



    }
}
