namespace Forms.Data;

/// <summary>
///     The type of value being stored for this field
/// </summary>
public enum FieldValueType
{
    Unknown = -1,

    /// <summary>
    ///     Regular text
    /// </summary>
    String = 0,

    /// <summary>
    ///     A whole number
    /// </summary>
    Integer = 1,

    /// <summary>
    ///     A number that may have a remainder
    /// </summary>
    Float = 2,

    /// <summary>
    ///     A number that represents a monetary value
    /// </summary>
    Currency = 3,

    /// <summary>
    ///     An http url/link
    /// </summary>
    Url = 4,

    /// <summary>
    ///     Any file attachment.
    /// </summary>
    Attachment = 5
}
