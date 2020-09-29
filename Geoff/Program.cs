using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Geoff.Intricacy_Control_Manager;

namespace Geoff
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            Linda = Linda;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static OptimalLanguageIntrinsicWordInterpretingAlgorithm Linda { get; set; }
    }
}
