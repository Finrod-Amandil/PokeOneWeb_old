using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PokeOneWeb.Data;
using PokeOneWeb.Data.Entities;
using PokeOneWeb.Services.ImageTiler;
using PokeOneWeb.ViewModels.Locations;

namespace PokeOneWeb.Controllers
{
    public class LocationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IImageTilerService _imageTilerService;

        public LocationController(ApplicationDbContext context, IImageTilerService imageTilerService)
        {
            _context = context;
            _imageTilerService = imageTilerService;
        }

        [HttpGet("locations/{locationGroupName}")]
        public IActionResult Detail(string locationGroupName)
        {
            var viewModel = new LocationDetailViewModel
            {
                LocationGroupName = locationGroupName
            };

            return View(viewModel);
        }

        [HttpGet("locations/new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("locations/new")]
        public IActionResult New(NewLocationViewModel viewModel)
        {
            var imageProperties = _imageTilerService.TileImage(viewModel.LocationMap, viewModel.LocationGroupName);

            var newLocation = new LocationGroup
            {
                Name = viewModel.LocationGroupName,
                Maps = new List<Map>
                {
                    new Map
                    {
                        Name = viewModel.LocationGroupName,
                        MaxZoomLevel = imageProperties.MaxZoomLevel,
                        ImageWidth = imageProperties.ImageWidth,
                        ImageHeight = imageProperties.ImageHeight
                    }
                }
            };
            _context.LocationGroups.Add(newLocation);
            _context.SaveChanges();

            return RedirectToAction("Detail", new {locationGroupName = "Location"});
        }
    }
}
