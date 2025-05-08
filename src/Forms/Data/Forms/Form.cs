namespace Forms.Data;

public class Form
{
    public string Id { get; set; }
    public ulong GuildId { get; set; }
    public DateTime CreatedAt { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public bool? AllowMultiple { get; set; }
    public DateTime? ExpiresAt { get; set; }
    public AnonymityMode? AnonymityMode { get; set; }

    public List<Field> Fields { get; set; }
    public List<Response> Responses { get; set; }
}
