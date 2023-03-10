using Serilog;


namespace CSharks.NFEs.Services.Helpers
{
    public static class CustomLogger
    {
        private static ILogger logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        internal static void LogInformation(string message)
        {
            logger.Information(message);
        }

        internal static void LogError(string message)
        {
            logger.Error(message);
        }
    }
}
