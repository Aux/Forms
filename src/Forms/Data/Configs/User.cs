namespace Forms.Data;

public class User
{
    public ulong Id { get; set; }

    public string PreferredLanguage { get; set; }

    public bool? IsAdmin { get; set; }
    public bool? IsBanned { get; set; }
}
