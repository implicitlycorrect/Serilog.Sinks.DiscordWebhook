using JNogueira.Discord.Webhook.Client;
using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting;

namespace Serilog.Sinks.DiscordWebhook;

public sealed class DiscordWebhookSink(string webhookUrl, ITextFormatter? textFormatter = null) : ILogEventSink
{
    private readonly DiscordWebhookClient _webhookClient = new(webhookUrl);

    public void Emit(LogEvent logEvent)
    {
        try
        {
            using var writer = new StringWriter();
            if (textFormatter is not null)
                textFormatter.Format(logEvent, writer);
            else
                writer.WriteLine(logEvent.RenderMessage());
            
            var logMessage = writer.ToString();
            _webhookClient.SendToDiscord(new DiscordMessage(logMessage), true);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}