using System.Collections.Generic;
using PokeOneWeb.ViewModels.ExcelGuideImport;

namespace PokeOneWeb.ViewModels.GuideImport
{
    public class LocationViewModel
    {
        public string LocationName { get; set; }
        public IList<PokemonSpawnViewModel> PokemonSpawns { get; set; }
        public IList<ItemViewModel> Items { get; set; }
        public IList<ExcelTrainerViewModel> Trainers { get; set; }
        public IList<OtherLocationFeatureViewModel> Other { get; set; }
    }
}
