using Microsoft.Extensions.Configuration;

namespace AppSettingInConsoleApplication;

public class Startup
{
    public Startup()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Setting.json", optional: false);

        IConfiguration config = builder.Build();

        Settings = config.GetSection("Settings").Get<ConsoleSettings>();

    }

    public ConsoleSettings Settings { get; private set; }
}