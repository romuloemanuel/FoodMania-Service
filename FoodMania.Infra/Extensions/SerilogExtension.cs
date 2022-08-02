

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace FoodMania.Infra.Extensions
{
    public static class SerilogExtension
    {
        public static ConfigureHostBuilder AddSerilog(ConfigureHostBuilder configuration)
        {
            configuration
                .UseSerilog((ctx, lc) =>
                    lc.MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Warning)
                    .Enrich.FromLogContext()
                    .WriteTo.Console()
                    .CreateLogger()
                 );

            //try/catch block will ensure any configuration issues are appropriately logged
            try
            {
                Log.Information("Staring the Host");
                //CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host Terminated Unexpectedly");
            }

            finally
            {
                Log.CloseAndFlush();
            }

            return configuration;
        }

        public static void UseSerilogC(this WebApplicationBuilder builder)
        {
            //builder.Host.AddSerilog();
        }
    }
}
