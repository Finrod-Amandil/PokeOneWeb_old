using Microsoft.AspNetCore.Http;
using PokeOneWeb.ViewModels.Locations;

namespace PokeOneWeb.Services.ImageTiler
{
    public interface IImageTilerService
    {
        ImagePropertiesViewModel TileImage(IFormFile file, string locationName);
    }
}
