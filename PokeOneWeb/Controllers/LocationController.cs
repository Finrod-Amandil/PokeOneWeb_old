using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var locationGroup =
                _context.LocationGroups
                    .Include(l => l.Maps)
                    .SingleOrDefault(l =>
                    l.Name.Equals(locationGroupName, StringComparison.Ordinal));

            if (string.IsNullOrEmpty(locationGroupName) || locationGroup is null)
            {
                return BadRequest("Invalid location group name.");
            }

            var viewModel = new LocationDetailViewModel
            {
                LocationGroupName = locationGroup.Name,
                LocationGroupDisplayName = locationGroup.DisplayName
            };

            if (locationGroup.Maps.Count > 0)
            {
                var mapData = locationGroup.Maps.First();

                viewModel.ImageProperties = new ImagePropertiesViewModel
                {
                    ImageWidth = mapData.ImageWidth,
                    ImageHeight = mapData.ImageHeight,
                    MaxZoomLevel = mapData.MaxZoomLevel
                };
            }

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
                DisplayName = viewModel.LocationGroupDisplayName,
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