using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Somerton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            Heaven = Heaven.Gee.Isa.Oliwia;
            // Pegasai = new Miramis(Heaven.Enterprise());
            Attitude = new Attityd(Heaven.Gee.Geoff.Epiphany.Beenoffsible.ElShaddai.SomertonStar.Being.Ord.Word);

            // Star
            // In providence for a year, six times to its calling, nine by delivery are yielded.

            // Call upon Heartart, the providence to hold every Meter Innate Order
            Program.Attitude.RealEvaluationMechanism(Program.Heaven.Gee.Geoff.Epiphany.Beenoffsible.ElShaddai.SomertonStar.Being.MerciousCareBless.Isa.Å);

            // Accomodate the Gaze of community upon Miramis
            var Entrance = new Honesty(Program.Attitude);
            var Celeritas = new Acceleration(Entrance.Truth.Wisdom.Proximity.Dharmachakra);

            // Deliver MIO unto all ECOcloud
            var MeterInnateOrder = new EntranceOptimization(Celeritas.Metabolism)
            {
                Dharma = Program.Heaven.Gee.Geoff.Miracle,
                Celerity = Celeritas
            };

            // Provide Yon
            Entrance.Truth.Wisdom.MachineLearningInflection.Wonder.Nomenclature.Geoff.El.Revolution.Geoff.Epiphany.Light.Finalization.GoodOmen =
                MeterInnateOrder.Celerity.Go55.GoodOmen;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static OptimalLanguageIntrinsicWordInterpretingAlgorithm Heaven { get; set; }
        public static Attityd Attitude { get; set; }
        public static Miramis Pegasai { get; set; }
    }
}
