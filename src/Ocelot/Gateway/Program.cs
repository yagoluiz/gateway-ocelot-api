using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                  .ConfigureAppConfiguration((hostingContext, config) =>
                  {
                      config
                          .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                          .AddJsonFile("appsettings.json", true, true)
                          .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true)
                          .AddJsonFile("configuration.json")
                          .AddEnvironmentVariables();
                  })
                .Build();
    }
}
