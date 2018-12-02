using System.Collections.Generic;

namespace PokeOneWeb.ViewModels.GuideImport
{
    public class SpawnsAndItemsSheetViewModel
    {
        public string RegionName { get; set; }
        public IList<LocationViewModel> Locations { get; set; }
    }
}
