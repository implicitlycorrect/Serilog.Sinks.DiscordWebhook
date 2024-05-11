using Serilog.Configuration;
using Serilog.Formatting;

namespace Serilog.Sinks.DiscordWebhook;

public static class Extensions
{
    public static LoggerConfiguration DiscordWebhook(this LoggerSinkConfiguration sinkConfiguration, string webhookUrl, ITextFormatter? textFormatter = null)
    {
        return sinkConfiguration.Sink(new DiscordWebhookSink(webhookUrl, textFormatter));
    }
}