using Microsoft.Extensions.Configuration;

namespace TimeItTook.Wpf.Test
{
    public class TestRigConfig : IDisposable 
        // NOTE: IDisposable is only implemented so that the config can act as a fixture for XUnit IClassFixture
    {
        // Test directory should be "/TimeItTook.Wpf.Test/bin/Debug/net10.0"
        private static string DEFAULT_APP_PATH = "../../../../TimeItTook.Wpf/bin/Debug/net10.0-windows/TimeItTook.Wpf.exe";
        private static int DEFAULT_MAX_RETRIES = 3;
        private static TimeSpan DEFAULT_CONNECTION_TIMEOUT_SECONDS = TimeSpan.FromSeconds(5); // default is 2 seconds
        private static TimeSpan DEFAULT_WINDOW_TIMEOUT_SECONDS = TimeSpan.FromSeconds(30);

        internal string AppPath { get; set; } = DEFAULT_APP_PATH;
        internal int MaxRetries { get; set; } = DEFAULT_MAX_RETRIES;
        internal TimeSpan ConnectionTimeoutSeconds { get; set; } = DEFAULT_CONNECTION_TIMEOUT_SECONDS;
        internal TimeSpan WindowTimeoutSeconds { get; set; } = DEFAULT_WINDOW_TIMEOUT_SECONDS;

        public TestRigConfig()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            var appPathSection = config.GetSection("AppPath");
            if (appPathSection.Exists() && appPathSection.Value is not null)
            {
                AppPath = appPathSection.Value;
            }
            if(int.TryParse(config.GetSection("MaxRetries").Value, out int maxRetries))
            {
                MaxRetries = maxRetries;
            }
            if (int.TryParse(config.GetSection("ConnectionTimeoutSeconds").Value, out int connectionTimeoutSeconds))
            {
                ConnectionTimeoutSeconds = TimeSpan.FromSeconds(connectionTimeoutSeconds);
            }
            if (int.TryParse(config.GetSection("WindowTimeoutSeconds").Value, out int windowTimeoutSeconds))
            {
                WindowTimeoutSeconds = TimeSpan.FromSeconds(windowTimeoutSeconds);
            }
        }

        public void Dispose()
        {
            // Nothing to Dispose. IDisposable is only implemented so that the config can act as a fixture for XUnit IClassFixture
        }
    }
}
