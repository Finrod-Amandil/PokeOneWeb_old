using System.Collections.Generic;

namespace PokeOneWeb.ViewModels.GuideImport
{
    public class PokemonSpawnViewModel
    {
        public string PokemonSpeciesName { get; set; }
        public string TimesOfDayString { get; set; }
        public string MethodName { get; set; }
        public Dictionary<string, bool?> FishingRodTypes { get; set; }
        public string RarityName { get; set; }
        public string Notes { get; set; }
    }
}
