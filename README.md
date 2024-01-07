# Serilog.Sinks.DiscordWebhook
Serilog.Sinks.DiscordWebhook is a .NET (C#) project designed to simplify logging in applications by offering a Serilog sink tailored for Discord through webhooks.
This project streamlines the process of sending log messages directly to a Discord channel using webhooks, providing an efficient way to monitor and manage logs within the Discord environment.
With an emphasis on ease of integration, Serilog.Sinks.DiscordWebhook is an ideal solution for developers looking to enhance their logging capabilities in Discord-based applications.

## Example Usage
```csharp
using Serilog;
using Serilog.Sinks.DiscordWebhook;

Log.Logger = new LoggerConfiguration()
    .WriteTo.DiscordWebhook(webhookUrl: "")
    .CreateLogger();
```
