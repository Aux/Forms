namespace Forms.Data;

/// <summary>
///     The method this field uses to obtain a value from a user
/// </summary>
public enum FieldEntryType
{
    Unknown = -1,

    /// <summary>
    ///     Regularly sent message
    /// </summary>
    Message = 0,

    /// <summary>
    ///     All messages until the user clicks submit
    /// </summary>
    MultiMessage = 1
}
