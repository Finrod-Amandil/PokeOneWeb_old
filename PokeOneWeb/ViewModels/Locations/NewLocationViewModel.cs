﻿using Microsoft.AspNetCore.Http;

namespace PokeOneWeb.ViewModels.Locations
{
    public class NewLocationViewModel
    {
        public string LocationGroupName { get; set; }
        public IFormFile LocationMap { get; set; }
    }
}
