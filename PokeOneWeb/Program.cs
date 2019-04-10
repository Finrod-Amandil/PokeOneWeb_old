using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using PokeOneWeb.Services;
using PokeOneWeb.Services.GuideImport;

namespace PokeOneWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //var importService = new GuideImportService();
            //importService.ImportGuideDataToDatabase();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
