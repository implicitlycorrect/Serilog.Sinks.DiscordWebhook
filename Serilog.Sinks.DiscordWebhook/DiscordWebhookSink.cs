using JNogueira.Discord.Webhook.Client;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Sinks.DiscordWebhook;

public sealed class DiscordWebhookSink(string webhookUrl) : ILogEventSink
{
    private readonly DiscordWebhookClient _webhookClient = new(webhookUrl);

    public void Emit(LogEvent logEvent)
    {
        _webhookClient.SendToDiscord(new DiscordMessage(logEvent.RenderMessage()), true);
    }
}