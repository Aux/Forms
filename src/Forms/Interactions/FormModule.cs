using Discord.Interactions;
using Discord.WebSocket;

namespace Forms.Interactions;

public class FormModule : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("form", "Begin form")]
    public async Task FormAsync(string form)
    {
        switch (Context.Channel)
        {
            case SocketDMChannel d:
                await DirectFormAsync(d, form);
                return;
            case SocketGuildChannel g:
                await GuildFormAsync(g, form);
                return;
            default:
                await RespondAsync("This command can only be run inside a guild or inside a dm channel.", ephemeral: true);
                return;
        }
    }

    private async Task DirectFormAsync(SocketDMChannel channel, string form)
    {

    }

    private async Task GuildFormAsync(SocketGuildChannel channel, string form)
    {

    }
}
