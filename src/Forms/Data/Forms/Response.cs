namespace Forms.Data;

public class Response
{
    public string Id { get; set; }
    public string FormId { get; set; }
    public ulong UserId { get; set; }
    public DateTime CreatedAt { get; set; }

    public bool ShowUser { get; set; } = false;
}
