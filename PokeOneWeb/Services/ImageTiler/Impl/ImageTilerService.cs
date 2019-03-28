using System;
using System.IO;
using ImageMagick;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using PokeOneWeb.ViewModels.Locations;

namespace PokeOneWeb.Services.ImageTiler.Impl
{
    public class ImageTilerService : IImageTilerService
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private static readonly int CLIENT_VIEWER_WIDTH = 1000;
        private static readonly int TILE_SIZE = 256;

        public ImageTilerService(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public ImagePropertiesViewModel TileImage(IFormFile file, string locationName)
        {
            if (file == null)
            {
                throw new NullReferenceException("IFormFile was null.");
            }

            var folderPath = Path.Combine(_hostingEnvironment.WebRootPath, "images", "location_maps",
                locationName);

            //Convert IFormFile to MagickImage.
            MagickImage originalImage = new MagickImage(file.OpenReadStream());

            //Determine how many zoom levels are required
            var maxZoomLevel = 0;
            var width = CLIENT_VIEWER_WIDTH;
            while (width < originalImage.Width)
            {
                width *= 2;
                maxZoomLevel++;
            }

            var aspectRatio = ((double)originalImage.Height) / originalImage.Width;
            var extendedClientViewerWidth = (int)(TILE_SIZE * Math.Ceiling((double)CLIENT_VIEWER_WIDTH / TILE_SIZE));
            var extendedClientViewerHeight = (int)(TILE_SIZE * Math.Ceiling((aspectRatio * CLIENT_VIEWER_WIDTH) / TILE_SIZE));

            for (int zoomLevel = 0; zoomLevel <= maxZoomLevel; zoomLevel++)
            {
                var currentImage = new MagickImage(originalImage);

                //Resize image to correct zoom level
                var zoomFactor = (int)Math.Pow(2, zoomLevel);
                var zoomedWidth = CLIENT_VIEWER_WIDTH * zoomFactor;

                var zoomedHeight = (int)(zoomedWidth * aspectRatio);
                currentImage.Resize(zoomedWidth, zoomedHeight);

                //Extend image to next larger multiple of tile size
                var extendedWidth = extendedClientViewerWidth * zoomFactor;
                var extendedHeight = extendedClientViewerHeight * zoomFactor;
                currentImage.Extent(
                    new MagickGeometry(extendedWidth, extendedHeight),
                    Gravity.Northwest,
                    new MagickColor(0, 0, 0));

                //Generate tiles
                var tileCountX = currentImage.Width / TILE_SIZE;
                var tileCountY = currentImage.Height / TILE_SIZE;

                for (var x = 0; x < tileCountX; x++)
                {
                    for (var y = 0; y < tileCountY; y++)
                    {
                        var tile = new MagickImage(currentImage);
                        tile.Crop(new MagickGeometry
                        {
                            X = x * TILE_SIZE,
                            Y = y * TILE_SIZE,
                            Width = TILE_SIZE,
                            Height = TILE_SIZE
                        });
                        SaveImage(tile, Path.Combine(folderPath, zoomLevel.ToString(), x.ToString()), $"{y.ToString()}.png");
                    }
                }
            }

            return new ImagePropertiesViewModel
            {
                MaxZoomLevel = maxZoomLevel,
                ImageWidth = originalImage.Width,
                ImageHeight = originalImage.Height
            };
        }

        private void SaveImage(MagickImage image, string folderPath, string fileName)
        {
            Directory.CreateDirectory(folderPath);

            using (var stream = new FileStream(Path.Combine(folderPath, fileName), FileMode.Create))
            {
                image.Write(stream);
            }

            image.Dispose();
        }
    }
}
