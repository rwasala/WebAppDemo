using Microsoft.Extensions.Configuration;

namespace WebAppDemo
{
    public class ConfigurationProvider
    {
        private static readonly IConfiguration Config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false)
            .AddEnvironmentVariables()
            .Build();

        public static string EnvName => Config.GetSection("EnvName").Value;
    }
}
