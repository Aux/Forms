using Forms.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(config =>
    {
        config.AddEnvironmentVariables();
    })
    .ConfigureLogging(logging =>
    {
        logging.AddSimpleConsole();
    })
    .AddDiscord()
    .ConfigureServices(services =>
    {
        services.AddHostedService<DiscordHost>();
        services.AddHostedService<InteractionsHost>();
    })
    .Build();

await host.RunAsync();