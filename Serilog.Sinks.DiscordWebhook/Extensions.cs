using Serilog.Configuration;

namespace Serilog.Sinks.DiscordWebhook;

public static class Extensions
{
    public static LoggerConfiguration DiscordWebhook(this LoggerSinkConfiguration sinkConfiguration, string webhookUrl)
    {
        return sinkConfiguration.Sink(new DiscordWebhookSink(webhookUrl));
    }
}