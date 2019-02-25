using Microsoft.AspNetCore.Mvc;
using PokeOneWeb.ViewModels.Locations;

namespace PokeOneWeb.Controllers
{
    public class LocationController : Controller
    {
        [HttpGet("locations/{locationGroupName}")]
        public IActionResult Detail(string locationGroupName)
        {
            var viewModel = new LocationDetailViewModel
            {
                LocationGroupName = locationGroupName
            };

            return View(viewModel);
        }
    }
}
